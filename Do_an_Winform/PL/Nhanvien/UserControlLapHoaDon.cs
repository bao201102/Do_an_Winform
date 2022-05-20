using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Nhanvien
{
    public partial class UserControlLapHoaDon : UserControl
    {
        bool isShowMemId = false;
        SanPhamDTO sp = new SanPhamDTO();
        LoaiSanPhamDTO loaisp = new LoaiSanPhamDTO();
        NhaSanXuatDTO nhasx = new NhaSanXuatDTO();
        List<SanPhamDTO> listSP = new List<SanPhamDTO>();
        List<KhachHangDTO> listKH = new List<KhachHangDTO>();
        KhachHangDTO khachHang = new KhachHangDTO();
        LoaiThanhVienDTO loaitv = new LoaiThanhVienDTO();
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public UserControlLapHoaDon()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlLapHoaDon_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                listSP = SanPhamBLL.GetAllProduct();
                listKH = KhachHangBLL.GetAllCustomer();
                foreach (SanPhamDTO sp in listSP)
                {
                    cbMaSP.Items.Add(sp.MaSP);
                }
                foreach(KhachHangDTO kh in listKH)
                {
                    cbMaKH.Items.Add(kh.MaKH);
                }
                txtDonGia.Enabled = false;
                txtTenSP.Enabled = false;
                txtLoaiSP.Enabled = false;
                txtThuongHieu.Enabled = false;
                txtSoLuong.Enabled = false;
                cbMaKH.Enabled = false;
                cbTichDiem.Enabled = false;
                txtTenKH.Enabled = true;
                txtLoaiTV.Enabled = false;
                rbKhachLe.Checked = true;
                //if (rbThanhVien.Checked)
                //{
                //    cbMaKH.Enabled = true;
                //    txtTenKH.Enabled = true;
                //    txtLoaiTV.Enabled = true;
                //    txtSoLuong.Enabled = true;

                //}
                lblTenNV.Text = NhanVienBLL.GetEmployee(frm_Nhanvien.taikhoan1.MaNguoiDung).TenNV;
                DateTime curDay = DateTime.Now;
                lblNgayBan.Text = (new DateTime(curDay.Year, curDay.Month, curDay.Day)).ToString("dd / MM / yyyy");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sp = SanPhamBLL.GetProductById(cbMaSP.Text);
            if(sp != null)
            {
                loaisp = LoaiSanPhamBLL.GetProTypeById(sp.MaLoaiSP);
                nhasx = NhaSanXuatBLL.GetManufacById(sp.MaNhaSX);
                txtDonGia.Enabled = true;
                txtTenSP.Enabled = true;
                txtLoaiSP.Enabled = true;
                txtThuongHieu.Enabled = true;
                txtSoLuong.Enabled = true;
                txtTenSP.Text = sp.TenSP;
                txtDonGia.Text = sp.DonGia.ToString();
                txtLoaiSP.Text = loaisp.TenLoaiSP;
                txtThuongHieu.Text = nhasx.TenNhaSX;
            }else
            {
                MessageBox.Show("Không tìm thấy sản phẩm. Vui lòng nhập lại");
            }
            
        }

        private void rbThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            isShowMemId = !isShowMemId;
            if(isShowMemId)
            {
                cbMaKH.Enabled = true;
                txtTenKH.Enabled = false;
                txtLoaiTV.Enabled = false;
                txtTenKH.Text = "";
                txtLoaiTV.Text = "";
                cbMaKH.Text = "";
            }
            else
            {
                cbMaKH.Enabled = false;
                txtTenKH.Text = "";
                txtLoaiTV.Text = "";
                cbMaKH.Text = "";
            }
            
        }

        private void btnSearchMem_Click(object sender, EventArgs e)
        {
            try
            {
                //txtTenKH.Enabled = true;
                //txtLoaiTV.Enabled = true;
                btnSearchMem.Enabled = true;
                cbTichDiem.Enabled = true;
                khachHang = KhachHangBLL.GetCustomerById(cbMaKH.Text);
                txtTenKH.Text = khachHang.TenKH;
                loaitv = LoaiThanhVienBLL.GetTypeMemById(khachHang.MaLoaiTVien);
                txtLoaiTV.Text = loaitv.TenLoaiTVien;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy khách hàng. Vui lòng thử lại");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }
            else
            {
                int donGia = int.Parse(txtDonGia.Text);
                int soLuong = int.Parse(txtSoLuong.Text);
                int tongCong = donGia * soLuong;
                lblSum.Text = tongCong.ToString() + "đ";
                lblDiscount.Text = "0%";
                if (txtLoaiTV.Text != "")
                {
                    if (txtLoaiTV.Text == "Đồng")
                    {
                        lblDiscount.Text = "5%";
                    }
                    else if (txtLoaiTV.Text == "Bạc")
                    {
                        lblDiscount.Text = "8%";
                    }
                    else if (txtLoaiTV.Text == "Vàng")
                    {
                        lblDiscount.Text = "10%";
                    }
                    else
                    {
                        lblDiscount.Text = "12%";
                    }
                }
                if (lblDiscount.Text == "0%")
                {
                    lblTotal.Text = (tongCong).ToString() + "đ";
                }else
                {
                    int discount = int.Parse(TachChuoi(lblDiscount.Text));
                    int thanhTien = tongCong - (tongCong * discount / 100);
                    lblTotal.Text = (thanhTien).ToString() + "đ";
                }
            }
            
        }
        public static string TachChuoi(string discount)
        {
            string v = "";
            for(int i = 0; i < discount.Length; i++)
            {
                if(discount[i] == '%')
                {
                    v = discount.Substring(0, i);
                }
            }
            return v;
        }

        private void rbKhachLe_CheckedChanged(object sender, EventArgs e)
        {
            cbMaKH.Enabled = false;
            txtTenKH.Enabled = true;
            txtLoaiTV.Enabled = false;
            txtTenKH.Text = "";
            cbMaKH.Text = "";
            txtLoaiTV.Text = "";
        }
    }
}
