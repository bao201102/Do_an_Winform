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

namespace Do_an_Winform.PL.Quanly.DoiTac
{
    public partial class frm_DoiTacKH : Form
    {
        public frm_DoiTacKH()
        {
            InitializeComponent();
        }

        private void frm_DoiTacKH_Load(object sender, EventArgs e)
        {
            dgKhachHang.DataSource = KhachHangBLL.GetAllCustomer();

            dgKhachHang.ReadOnly = true;
            dgKhachHang.AllowUserToResizeColumns = false;
            dgKhachHang.AllowUserToResizeRows = false;

            dgKhachHang.Columns[0].Visible = false;
            dgKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgKhachHang.Columns[2].HeaderText = "Giới tính";
            dgKhachHang.Columns[3].HeaderText = "Email";
            dgKhachHang.Columns[4].HeaderText = "Số điện thoại";
            dgKhachHang.Columns[5].HeaderText = "Địa chỉ";
            dgKhachHang.Columns[6].HeaderText = "Loại thành viên";
            dgKhachHang.Columns[7].HeaderText = "Điểm tích lũy";
        }

        private void txtFind_TextChange(object sender, EventArgs e)
        {
            try
            {
                dgKhachHang.DataSource = KhachHangBLL.GetCustomerByName(txtFind.Text);

                dgKhachHang.Columns[0].Visible = false;
                dgKhachHang.Columns[1].HeaderText = "Tên khách hàng";
                dgKhachHang.Columns[2].HeaderText = "Giới tính";
                dgKhachHang.Columns[3].HeaderText = "Email";
                dgKhachHang.Columns[4].HeaderText = "Số điện thoại";
                dgKhachHang.Columns[5].HeaderText = "Địa chỉ";
                dgKhachHang.Columns[6].HeaderText = "Loại thành viên";
                dgKhachHang.Columns[7].HeaderText = "Điểm tích lũy";

            }
            catch (Exception)
            {

            }
        }

        private void btnCreateRP_Click(object sender, EventArgs e)
        {
            frm_BaoCaoDoiTac form = new frm_BaoCaoDoiTac("khachhang");
            form.ShowDialog();
        }
    }
}
