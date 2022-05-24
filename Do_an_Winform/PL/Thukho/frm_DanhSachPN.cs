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
    public partial class frm_DanhSachPN : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public frm_DanhSachPN(TaiKhoanDTO user)
        {
            InitializeComponent();
            taikhoan = user;
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

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Nhap(taikhoan));
        }

        private void frm_DanhSachPN_Load(object sender, EventArgs e)
        {
            gridviewDSNhap.DataSource = PhieuNhapHangBLL.GetAll();
            gridviewDSNhap.Columns[0].HeaderText = "Mã phiếu nhập";
            gridviewDSNhap.Columns[1].HeaderText = "Ngày tạo PN";
            gridviewDSNhap.Columns[2].HeaderText = "Mã nhân viên";
            gridviewDSNhap.Columns[3].HeaderText = "Mã nhà cung cấp";
            gridviewDSNhap.Columns[4].HeaderText = "Thành tiền";
            gridviewDSNhap.Columns[5].Visible = false;
        }

        private void gridviewDSNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string manv = gridviewDSNhap.CurrentRow.Cells[2].Value.ToString();
            string mancc = gridviewDSNhap.CurrentRow.Cells[3].Value.ToString();
            string mapn = gridviewDSNhap.CurrentRow.Cells[0].Value.ToString();

            frm_XemPN frm = new frm_XemPN();
            openChildForm(frm);
            frm.lblTenNV.Text = NhanVienBLL.GetEmployeeById(manv).TenNV.ToString();
            frm.lblDate.Text = gridviewDSNhap.CurrentRow.Cells[1].Value.ToString();
            frm.lblNCC.Text = NhaCungCapBLL.GetNhaCungCapByID(mancc).TenNCC.ToString();
            frm.gridXemPN.DataSource = ChiTietPhieuNhapBLL.GetAllByID(mapn);
            frm.gridXemPN.Columns[0].Visible = false;
            frm.gridXemPN.Columns[1].HeaderText = "Mã sản phẩm";
            frm.gridXemPN.Columns[2].HeaderText = "Tên sản phẩm";
            frm.gridXemPN.Columns[3].HeaderText = "Số lượng";
            frm.gridXemPN.Columns[4].Visible = false;
            frm.gridXemPN.Columns[5].Visible = false;
        }
    }
}
