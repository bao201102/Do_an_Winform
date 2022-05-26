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

namespace Do_an_Winform.PL.Quanly.QLDoiTac
{
    public partial class frm_TaoTaiKhoan : Form
    {
        TaiKhoanDTO user = new TaiKhoanDTO();
        public frm_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private bool CheckNullTextbox()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "" || txtHoten.Text == "" || 
                txtEmail.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (CheckNullTextbox())
            {
                bunifuSnackbar1.Show(new frm_Quanly(user), "Vui lòng nhập đủ thông tin vào ô trống", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                if (txtPassword.Text == txtPassword2.Text)
                {
                    TaiKhoanDTO taikhoan = new TaiKhoanDTO();
                    taikhoan.UserName = txtUsername.Text;
                    taikhoan.MatKhau = txtPassword.Text;
                    taikhoan.MaLoaiNV = cbLoaitk.SelectedValue.ToString();

                    if (TaiKhoanBLL.AddAccount(taikhoan))
                    {
                        NhanVienDTO nhanvien = new NhanVienDTO();
                        nhanvien.TenNV = txtHoten.Text;
                        nhanvien.Email = txtEmail.Text;
                        nhanvien.DiaChi = txtDiachi.Text;
                        nhanvien.GioiTinh = cbGender.Text;
                        nhanvien.SĐT = txtSDT.Text;
                        nhanvien.MaLoaiNV = cbLoaitk.SelectedValue.ToString();
                        nhanvien.MaNguoiDung = TaiKhoanBLL.GetUserId(txtUsername.Text);
                        if (NhanVienBLL.AddEmployee(nhanvien))
                        {
                            bunifuSnackbar1.Show(new frm_Quanly(user), "Bạn đã thêm nhân viên mới thành công", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                            lblReturn_Click(sender, e);
                        }
                    }
                }
                else
                {
                    bunifuSnackbar1.Show(new frm_Quanly(user), "Mật khẩu nhập lại không trùng khớp", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
            }
            
        }

        private void frm_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cbLoaitk.DataSource = LoaiNhanVienBLL.GetAllEmpType();
            cbLoaitk.DisplayMember = "TenLoaiNV";
            cbLoaitk.ValueMember = "MaLoaiNV";
            cbLoaitk.SelectedIndex = 0;

            cbGender.SelectedIndex = 0;

            txtPassword.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }

        private void lblReturn_MouseHover(object sender, EventArgs e)
        {
            lblReturn.Font = new Font(lblReturn.Font, FontStyle.Underline);
        }

        private void lblReturn_MouseLeave(object sender, EventArgs e)
        {
            lblReturn.Font = new Font(lblReturn.Font, FontStyle.Regular);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
