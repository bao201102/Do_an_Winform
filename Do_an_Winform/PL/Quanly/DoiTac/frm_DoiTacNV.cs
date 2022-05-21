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
    public partial class frm_DoiTacNV : Form
    {
        public frm_DoiTacNV()
        {
            InitializeComponent();
        }

        private void btTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            string name = txtTimKiemNhanVien.Text;
            if (name != "")
            {
                List<NhanVienDTO> list = NhanVienBLL.GetEmployeeWithName(name);
                dgNhanVien.DataSource = list;
            }
            else
            {
                List<NhanVienDTO> list = NhanVienBLL.GetAllEmployee();
                dgNhanVien.DataSource = list;
            }
            dgNhanVien.ReadOnly = true;
            dgNhanVien.AllowUserToResizeColumns = false;
            dgNhanVien.AllowUserToResizeRows = false;
            dgNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgNhanVien.Columns[2].HeaderText = "Giới tính";
            dgNhanVien.Columns[3].HeaderText = "Email";
            dgNhanVien.Columns[4].HeaderText = "Số điện thoại";
            dgNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dgNhanVien.Columns[6].HeaderText = "Mã loại nhân viên";
            dgNhanVien.Columns[7].HeaderText = "Mã người dùng";
            dgNhanVien.Columns[8].HeaderText = "Trạng thái";
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            frm_ThemNV form = new frm_ThemNV();
            form.ShowDialog();
        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTimKiemNhanVien.Text = dgNhanVien.SelectedCells[0].OwningRow.Cells["TenNV"].Value.ToString();
        }
    }
}
