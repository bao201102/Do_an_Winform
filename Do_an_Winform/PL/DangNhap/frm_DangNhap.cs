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
            txtUsername.ForeColor = Color.Black;
            txtPassword.ForeColor = Color.Black;
            txtPassword._TextBox.UseSystemPasswordChar = true;
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

        bool seePass = true;
        private void btnEye_Click(object sender, EventArgs e)
        {
            seePass = !seePass;
            if (seePass == true)
            {
<<<<<<< HEAD
                txtPassword._TextBox.UseSystemPasswordChar = true;
                txtPassword._TextBox.PasswordChar = '*';
            }
            else
            {
                txtPassword._TextBox.UseSystemPasswordChar = false;
=======
                btnEye.BackgroundImage = Properties.Resources.icons8_eyelashes_2d_32;
                txtPassword._TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                btnEye.BackgroundImage = Properties.Resources.eye_icon;
                txtPassword._TextBox.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername._TextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
            else if (txtPassword._TextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
            {
                TaiKhoan user = new TaiKhoan();
                user.TaiKhoan1 = txtUsername._TextBox.Text;
                user.MatKhau = txtPassword._TextBox.Text;
                if (TaiKhoanBLL.GetUser(user) != null)
                {
                    MessageBox.Show("Đăng nhập thành công");
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
                    MessageBox.Show("Sai tên tài khoản và mật khẩu. Vui lòng thử lại");
                }
>>>>>>> 159039179d0f5ba3b14dca6d235e218d8f440cf3
            }
        }
    }
}
