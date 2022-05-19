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
                txtTenKH.Enabled = false;
                txtLoaiTV.Enabled = false;
                rbKhachLe.Checked = true;
                //if (rbThanhVien.Checked)
                //{
                //    cbMaKH.Enabled = true;
                //    txtTenKH.Enabled = true;
                //    txtLoaiTV.Enabled = true;
                //    txtSoLuong.Enabled = true;
                    
                //}
                
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
                
            }
            else
            {
                cbMaKH.Enabled = false;
            }
            
        }

        private void btnSearchMem_Click(object sender, EventArgs e)
        {
            try
            {
                txtTenKH.Enabled = true;
                txtLoaiTV.Enabled = true;
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
    }
}
