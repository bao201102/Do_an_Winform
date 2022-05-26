using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.DangNhap;
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
    public partial class frm_NVien : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        NhanVienDTO nhanvien = new NhanVienDTO();
        LoaiNhanVienDTO loaiNV = new LoaiNhanVienDTO();
        public static TaiKhoanDTO taikhoan1 = new TaiKhoanDTO();
        public frm_NVien(TaiKhoanDTO user)
        {
            InitializeComponent();
            this.Width = 1600;
            this.Height = 900;
            taikhoan = user;
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

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
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn muốn thoát chương trình ?");
            if (result)
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

        private void frm_NVien_Load(object sender, EventArgs e)
        {
            subuserPanel.Visible = false;
            openChildUsercontrol(new UserControlKhachHang());
            NhanVienDTO emp = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);
            nhanvien = emp;
            userBtn.Text = emp.TenNV;
            LoaiNhanVienDTO empType = LoaiNhanVienBLL.GetEmpType(emp.MaLoaiNV);
            loaiNV = empType;
            taikhoan1 = taikhoan;
        }
        
        

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildUsercontrol(new UserControlKhachHang());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildUsercontrol(new UserControlSanPham());
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_DSHoaDon(taikhoan));
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Thongtin(nhanvien, loaiNV, this));
        }
        private Form activeForm = null;
        private UserControl activeUserControl = null;
        private void openChildUsercontrol(UserControl userControl)
        {
            if (activeUserControl != null)
            {
                activeUserControl.Hide();
            }
            activeUserControl = userControl;
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            mainPanel.Tag = userControl;
            userControl.BringToFront();
            userControl.Show();
        }
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
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn muốn đăng xuất ?");
            if (result)
            {
                frm_DangNhap loginform = new frm_DangNhap();
                this.Hide();
                loginform.ShowDialog();
                this.Close();
            }
        }
    }
}
