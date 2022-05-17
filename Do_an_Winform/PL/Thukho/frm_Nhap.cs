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

namespace Do_an_Winform.PL.Thukho
{
    public partial class frm_Nhap : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public frm_Nhap(TaiKhoanDTO user)
        {
            InitializeComponent();
            taikhoan = user;
        }

        private void frm_Nhap_Load(object sender, EventArgs e)
        {
            NhanVienDTO emp = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);
            lblTenNV.Text = emp.TenNV;

            cbbNhaCC.DataSource = NhaCungCapBLL.GetNhaCungCap();
            cbbNhaCC.DisplayMember = "TenNCC";
            cbbNhaCC.ValueMember = "MaNCC";

            cbbTenSP.DataSource = SanPhamBLL.GetAllProduct();
            cbbTenSP.DisplayMember = "TenSP";
            cbbTenSP.ValueMember = "MaSP";

            lblDongia.Text = SanPhamBLL.GetProductByName(cbbTenSP.Text.ToString()).DonGia.ToString();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            lblDongia.Text = SanPhamBLL.GetProductByName(cbbTenSP.Text.ToString()).DonGia.ToString();
        }

        private void cbbTenSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDongia.Text = SanPhamBLL.GetProductByName(cbbTenSP.Text.ToString()).DonGia.ToString();
            }
            catch (Exception)
            {                
            }
        }
    }
}
