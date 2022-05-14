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

namespace Do_an_Winform.PL.DangNhap
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txtPassword._TextBox.PasswordChar = '*';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername._TextBox.Text == "" || txtPassword._TextBox.Text == "")
            {
                bunifuSnackbar1.Show(this, "Vui lòng nhập tài khoản và mật khẩu", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                TaiKhoan user = new TaiKhoan();
                user.TaiKhoan1 = txtUsername._TextBox.Text.Trim();
                user.MatKhau = txtPassword._TextBox.Text.Trim();
                if (TaiKhoanBLL.GetUser(user) != null)
                {
                    TaiKhoanDTO userLogin = TaiKhoanBLL.GetUser(user);
                    if (userLogin.MaLoaiNV == "LNV001")
                    {
                        frm_Nhanvien frmNhanVien = new frm_Nhanvien(userLogin);
                        //Form frmEmp = new frm_Nhanvien(userLogin);
                        frmNhanVien.Show();
                        //this.Close();
                    }
                    else if (userLogin.MaLoaiNV == "LNV002")
                    {
                        frm_Quanly frmQuanLi = new frm_Quanly(userLogin);
                        frmQuanLi.Show();
                        //this.Close();
                    }
                    else if (userLogin.MaLoaiNV == "LNV003")
                    {
                        frm_Thukho frmThuKho = new frm_Thukho(userLogin);
                        frmThuKho.Show();
                        //this.Close();
                    }
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Sai tên hoặc mật khẩu vui lòng thử lại", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
            }
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (txtPassword._TextBox.UseSystemPasswordChar)
            {
                txtPassword._TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword._TextBox.UseSystemPasswordChar = true;
                txtPassword._TextBox.PasswordChar = '*';
            }
        }
    }
}
