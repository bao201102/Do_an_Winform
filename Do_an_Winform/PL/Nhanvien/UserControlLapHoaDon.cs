using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
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
        NhanVienDTO nhanVien = new NhanVienDTO();
        List<HoaDonDTO> listHoaDon = new List<HoaDonDTO>();
        List<ChiTietHoaDonDTO> listCTHD = new List<ChiTietHoaDonDTO>();
        public UserControlLapHoaDon()
        {
            InitializeComponent();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlLapHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                nhanVien = NhanVienBLL.GetEmployee(frm_NVien.taikhoan1.MaNguoiDung);
            }
            catch (Exception)
            {
            }
            
            if (!DesignMode)
            {
                listSP = SanPhamBLL.GetAllProduct();
                
                foreach (SanPhamDTO sp in listSP)
                {
                    cbTenSP.Items.Add(sp.TenSP);
                }
                
                txtDonGia.Enabled = false;
                txtMaSP.Enabled = false;
                txtLoaiSP.Enabled = false;
                
                txtSoLuong.Enabled = false;
                cbTenKH.Enabled = false;
                cbTichDiem.Enabled = false;
                txtMaKH.Enabled = true;
                txtLoaiTV.Enabled = false;
                rbKhachLe.Checked = true;
                //if (rbThanhVien.Checked)
                //{
                //    cbMaKH.Enabled = true;
                //    txtTenKH.Enabled = true;
                //    txtLoaiTV.Enabled = true;
                //    txtSoLuong.Enabled = true;

                //}
                lblTenNV.Text = nhanVien.TenNV;
                DateTime curDay = DateTime.Now;
                lblNgayBan.Text = (new DateTime(curDay.Year, curDay.Month, curDay.Day)).ToString("dd / MM / yyyy");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sp = SanPhamBLL.GetProductByName(cbTenSP.Text);
            try
            {
                loaisp = LoaiSanPhamBLL.GetProTypeById(sp.MaLoaiSP);
                nhasx = NhaSanXuatBLL.GetManufacById(sp.MaNhaSX);
                txtDonGia.Enabled = true;
                txtMaSP.Enabled = true;
                txtLoaiSP.Enabled = true;
                
                txtSoLuong.Enabled = true;
                txtMaSP.Text = sp.MaSP;
                txtDonGia.Text = sp.DonGia.ToString();
                txtLoaiSP.Text = loaisp.TenLoaiSP;
                
            }catch
            {
                MessageBox.Show("Không tìm thấy sản phẩm. Vui lòng nhập lại");
            }
            
        }

        private void rbThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            listKH = KhachHangBLL.GetAllCustomer();
            isShowMemId = !isShowMemId;
            if(isShowMemId)
            {
                cbTenKH.Enabled = true;
                txtMaKH.Enabled = false;
                txtLoaiTV.Enabled = false;
                txtMaKH.Text = "";
                txtLoaiTV.Text = "";
                cbTenKH.Text = "";
                
                foreach (KhachHangDTO kh in listKH)
                {
                    cbTenKH.Items.Add(kh.TenKH);
                }
            }
            else
            {
                cbTenKH.Enabled = false;
                txtMaKH.Text = "";
                txtLoaiTV.Text = "";
                cbTenKH.Text = "";
                foreach (KhachHangDTO kh in listKH)
                {
                    cbTenKH.Items.Remove(kh.TenKH);
                }
                btnSearchMem.Enabled = false;
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
                khachHang = KhachHangBLL.GetCustomerByName(cbTenKH.Text);
                txtMaKH.Text = khachHang.MaKH;
                loaitv = LoaiThanhVienBLL.GetTypeMemById(khachHang.MaLoaiTVien);
                txtLoaiTV.Text = loaitv.TenLoaiTVien;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy khách hàng. Vui lòng thử lại");
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
            cbTenKH.Enabled = true;
            txtMaKH.Enabled = false;
            txtLoaiTV.Enabled = false;
            txtMaKH.Text = "";
            cbTenKH.Text = "";
            txtLoaiTV.Text = "";
            btnSearchMem.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text == "")
            {
                MessageBox.Show("Chưa có mã hóa đơn. Ấn nút tạo hóa đơn để có mã hóa đơn");
            }
            if (cbTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
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
                lblSum1.Text = tongCong.ToString() + "đ";
                lblDiscount1.Text = "0%";
                if (txtLoaiTV.Text != "")
                {
                    if (txtLoaiTV.Text == "Đồng")
                    {
                        lblDiscount1.Text = "5%";
                    }
                    else if (txtLoaiTV.Text == "Bạc")
                    {
                        lblDiscount1.Text = "8%";
                    }
                    else if (txtLoaiTV.Text == "Vàng")
                    {
                        lblDiscount1.Text = "10%";
                    }
                    else
                    {
                        lblDiscount1.Text = "12%";
                    }
                }
                if (lblDiscount1.Text == "0%")
                {
                    lblTotal1.Text = (tongCong).ToString() + "đ";
                }
                else
                {
                    int discount = int.Parse(TachChuoi(lblDiscount1.Text));
                    int thanhTien = tongCong - (tongCong * discount / 100);
                    lblTotal1.Text = (thanhTien).ToString() + "đ";
                }
            }
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            listHoaDon = HoaDonBLL.GetAllBill();
            int count = listHoaDon.Count + 1;
            string maHD = "HD" + count.ToString("000");
            txtMaHD.Text = maHD;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chưa có mã hóa đơn. Ấn nút tạo hóa đơn để có mã hóa đơn");
            }
            else if (cbTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }else if (lblSum1.Text == "")
            {
                MessageBox.Show("Vui lòng nhấn nút thanh toán để thanh toán trước");
            }else
            {
                int total = int.Parse(TachThanhTien(lblTotal1.Text));
                HoaDonDTO hoaDon = new HoaDonDTO();
                listHoaDon = HoaDonDAL.GetAllBill();

                hoaDon = CheckIdBill(listHoaDon, txtMaHD.Text);
                if (hoaDon.MaHD != "")
                {
                    hoaDon.ThanhTien += total;
                    if (HoaDonBLL.EditBill(hoaDon) == true)
                    {
                        MessageBox.Show("Cập nhật thông tin hóa đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                {
                    hoaDon.MaHD = txtMaHD.Text;
                    DateTime curDay = DateTime.Now;
                    hoaDon.NgayTaoHD = (new DateTime(curDay.Year, curDay.Month, curDay.Day));
                    try
                    {
                        nhanVien = NhanVienBLL.GetEmployee(frm_NVien.taikhoan1.MaNguoiDung);
                    }
                    catch (Exception)
                    {
                    }
                    hoaDon.MaNV = nhanVien.MaNV;
                    if (txtMaKH.Text == "")
                    {
                        hoaDon.MaKH = null;
                    }
                    else
                    {
                        hoaDon.MaKH = txtMaKH.Text;
                    }
                    hoaDon.ThanhTien = total;
                    hoaDon.TrangThai = "1";
                    if (HoaDonDAL.AddNewBill(hoaDon))
                    {
                        MessageBox.Show("Thêm hóa đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                    
                }


                ChiTietHoaDonDTO chiTietHD = new ChiTietHoaDonDTO();
                chiTietHD.MaHD = txtMaHD.Text;
                chiTietHD.MaSP = txtMaSP.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                chiTietHD.SoLuong = soLuong;
                int thanhTien = int.Parse(TachThanhTien(lblTotal1.Text));
                chiTietHD.ThanhTien = thanhTien;
                chiTietHD.TrangThai = "1";
                bool result = ChiTietHoaDonBLL.AddNewBillDetail(chiTietHD);
                if (result)
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
                listCTHD = ChiTietHoaDonDAL.GetAllDetailBill(txtMaHD.Text);
                dgvAllDetailBill.DataSource = listCTHD;
                dgvAllDetailBill.Columns[0].HeaderText = "Mã HD";
                dgvAllDetailBill.Columns[1].HeaderText = "Mã SP";
                dgvAllDetailBill.Columns[2].HeaderText = "Số lượng";
                dgvAllDetailBill.Columns[3].HeaderText = "Thành tiền";
                dgvAllDetailBill.Columns[4].HeaderText = "Trạng thái";
            }
        }
        private static string TachThanhTien(string thanhTien)
        {
            string v = "";
            for (int i = 0; i < thanhTien.Length; i++)
            {
                if (thanhTien[i] == 'đ')
                {
                    v = thanhTien.Substring(0, i);
                }
            }
            return v;
        }
        public static HoaDonDTO CheckIdBill(List<HoaDonDTO> listHoaDon, string maHD)
        {
            HoaDonDTO hoaDon = new HoaDonDTO();
            for (int i = 0; i < listHoaDon.Count; i++)
            {
                if (listHoaDon[i].MaHD == maHD)
                {
                    hoaDon = listHoaDon[i];
                    break;
                }
            }
            return hoaDon;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtLoaiTV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
