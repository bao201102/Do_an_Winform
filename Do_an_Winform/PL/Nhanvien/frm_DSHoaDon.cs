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
    public partial class frm_DSHoaDon : Form
    {
        public static TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
        public frm_DSHoaDon(TaiKhoanDTO user)
        {
            InitializeComponent();
            taiKhoan = user;
        }
        private UserControl activeUC = null;
        private void openChildUserControl(UserControl userControl)
        {
            if (activeUC != null)
            {
                activeUC.Hide();
            }
            activeUC = userControl;
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            mainPanel.Tag = userControl;
            userControl.BringToFront();
            userControl.Show();
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
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTaoDon_Click_1(object sender, EventArgs e)
        {
            openChildUserControl(new UserControlLapHoaDon());
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            gridviewDSHoaDon.DataSource = HoaDonBLL.GetAllBill();
            gridviewDSHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            gridviewDSHoaDon.Columns[1].HeaderText = "Ngày tạo HD";
            gridviewDSHoaDon.Columns[2].HeaderText = "Mã nhân viên";
            gridviewDSHoaDon.Columns[3].HeaderText = "Mã KH";
            gridviewDSHoaDon.Columns[4].HeaderText = "Thành tiền";
            gridviewDSHoaDon.Columns[5].Visible = false;
        }

        private void gridviewDSHoaDon_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string manv = gridviewDSHoaDon.CurrentRow.Cells[2].Value.ToString();
            string date = gridviewDSHoaDon.CurrentRow.Cells[1].Value.ToString();
            string mahd = gridviewDSHoaDon.CurrentRow.Cells[0].Value.ToString();
            string tenNV = NhanVienBLL.GetEmployeeById(manv).TenNV;
            string ngayTao = date;
            frm_XemHD frm = new frm_XemHD(tenNV, ngayTao);
            openChildForm(frm);
            frm.gridXemHD.DataSource = HoaDonBLL.GetAllBillById(mahd);
            frm.gridXemHD.Columns[0].Visible = false;
            frm.gridXemHD.Columns[1].HeaderText = "Mã sản phẩm";
            frm.gridXemHD.Columns[2].HeaderText = "Tên sản phẩm";
            frm.gridXemHD.Columns[3].HeaderText = "Số lượng";
            frm.gridXemHD.Columns[4].HeaderText = "Thành tiền";
            frm.gridXemHD.Columns[5].Visible = false;
        }

        private void frm_DSHoaDon_Load_1(object sender, EventArgs e)
        {
            gridviewDSHoaDon.DataSource = HoaDonBLL.GetAllBill();
            gridviewDSHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            gridviewDSHoaDon.Columns[1].HeaderText = "Ngày tạo HD";
            gridviewDSHoaDon.Columns[2].HeaderText = "Mã nhân viên";
            gridviewDSHoaDon.Columns[3].HeaderText = "Mã KH";
            gridviewDSHoaDon.Columns[4].HeaderText = "Thành tiền";
            gridviewDSHoaDon.Columns[5].Visible = false;
        }
    }

}
