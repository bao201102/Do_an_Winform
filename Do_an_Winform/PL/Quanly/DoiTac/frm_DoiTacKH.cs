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

        private void btTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            string name = txtTimKiemKhachHang.Text;
            if (name != "")
            {
                List<KhachHangDTO> list = KhachHangBLL.GetCustomerWithName(name);
                dgKhachHang.DataSource = list;
            }
            else
            {
                List<KhachHangDTO> list = KhachHangBLL.GetAllCustomer();
                dgKhachHang.DataSource = list;
            }
            dgKhachHang.ReadOnly = true;
            dgKhachHang.AllowUserToResizeColumns = false;
            dgKhachHang.AllowUserToResizeRows = false;
            dgKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgKhachHang.Columns[2].HeaderText = "Giới tính";
            dgKhachHang.Columns[3].HeaderText = "Email";
            dgKhachHang.Columns[4].HeaderText = "Số điện thoại";
            dgKhachHang.Columns[5].HeaderText = "Địa chỉ";
            dgKhachHang.Columns[6].HeaderText = "Mã loại thành viên";
            dgKhachHang.Columns[7].HeaderText = "Điểm tích lũy";
            dgKhachHang.Columns[8].HeaderText = "Trạng thái";
        }

        private void btThemKH_Click(object sender, EventArgs e)
        {
            frm_ThemKH form = new frm_ThemKH();
            form.ShowDialog();
        }

        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTimKiemKhachHang.Text = dgKhachHang.SelectedCells[0].OwningRow.Cells["TenKH"].Value.ToString();
        }
    }
}
