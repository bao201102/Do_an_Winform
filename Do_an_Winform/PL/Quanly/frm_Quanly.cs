using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.DangNhap;
using Do_an_Winform.PL.Quanly.DoiTac;
using Do_an_Winform.PL.Quanly.QLBC;
using Do_an_Winform.PL.Quanly.QLTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly
{
    public partial class frm_Quanly : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        NhanVienDTO nhanvien = new NhanVienDTO();
        LoaiNhanVienDTO loainhanvien = new LoaiNhanVienDTO();
        
        public frm_Quanly(TaiKhoanDTO user)
        {
            InitializeComponent();
            this.Width = 1600;
            this.Height = 900;
            taikhoan = user;
        }

        private void frm_Quanly_Load(object sender, EventArgs e)
        {
            subuserPanel.Visible = false;
            subdoitacPanel.Visible = false;
            subhoadonPanel.Visible = false;
            nhanvien = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);
            loainhanvien = LoaiNhanVienBLL.GetEmpType(nhanvien.MaLoaiNV);
            userBtn.Text = nhanvien.TenNV;
            
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
                subdoitacPanel.Visible = false;
                subhoadonPanel.Visible = false;
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

        private void btnQLDT_Click(object sender, EventArgs e)
        {
            if (subdoitacPanel.Visible == false)
            {
                subdoitacPanel.Visible = true;
            }
            else
            {
                subdoitacPanel.Visible = false;
            }
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            if (subhoadonPanel.Visible == false)
            {
                subhoadonPanel.Visible = true;
            }
            else
            {
                subhoadonPanel.Visible = false;
            }
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

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
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

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Thongtin(nhanvien, loainhanvien, this));
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLSP());
        }
       
        private void btDoiTac_NV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DoiTacNV());
        }

        private void btDoiTac_KH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DoiTacKH());
        }

        private void btDoiTac_NCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DoiTacNCC());
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLTK());
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_HDNH());
        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_HDBH());
        }

        private void btnQLDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TKDT());
        }

        private void btnQLBC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLBC());
        }
    }
}
