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

namespace Do_an_Winform
{
    public partial class frm_Nhanvien : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public frm_Nhanvien(TaiKhoanDTO user)
        {
            this.Width = 1600;
            this.Height = 900;
            taikhoan = user;
        }

        private void slideBtn_Click(object sender, EventArgs e)
        {

            if (sidemenu.Width == 55)
            {
                Transition.HideSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
                sidemenu.Visible = false;
                sidemenu.Width = 250;
                mainPanel.Location = new Point(260, 45);
                mainPanel.Width -= 195;
                Transition.ShowSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
            {
                Transition.HideSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
                sidemenu.Visible = false;
                sidemenu.Width = 55;
                mainPanel.Location = new Point(65, 45);
                subuserPanel.Visible = false;
                mainPanel.Width += 195;
                Transition.ShowSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
            }

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

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            if (subuserPanel.Visible == false)
            {
                subuserPanel.Visible = true;
            }
            else
            {
                subuserPanel.Visible = false;
            }
        }

        private void frm_Nhanvien_Load(object sender, EventArgs e)
        {
            subuserPanel.Visible = false;
            userControlKhachHang1.BringToFront();
            NhanVienDTO emp = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);
            userBtn.Text = emp.TenNV;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            userControlKhachHang1.BringToFront();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            userControlSanPham1.BringToFront();
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            userControlLapHoaDon1.BringToFront();
        }

        private void btnDKTV_Click(object sender, EventArgs e)
        {
            userControlDKThanhVien1.BringToFront();
        }
    }
}
