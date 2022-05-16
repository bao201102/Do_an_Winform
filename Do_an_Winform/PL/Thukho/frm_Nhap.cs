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
            cbbNhaCC.DataSource = NhaCungCapBLL.GetNhaCungCap();
            cbbNhaCC.DisplayMember = "TenNCC";
            cbbNhaCC.ValueMember = "MaNCC";

            //cbbTenSP.DataSource = SanPhamBLL.GetProduct();
            //cbbTenSP.DisplayMember = "TenSP";
            //cbbTenSP.ValueMember = "MaSP";

            NhanVienDTO emp = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);
            lblTenNV.Text = emp.TenNV;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
