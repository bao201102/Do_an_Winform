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
    public partial class frm_DoiTacNCC : Form
    {
        public frm_DoiTacNCC()
        {
            InitializeComponent();
        }

        private void btTimKiemNCC_Click(object sender, EventArgs e)
        {
            string name = txtTimKiemNCC.Text;
            if (name != "")
            {
                List<NhaCungCapDTO> list = NhaCungCapBLL.GetSupplyWithName(name);
                dgNhaCungCap.DataSource = list;
            }
            else
            {
                List<NhaCungCapDTO> list = NhaCungCapBLL.GetAllSupply();
                dgNhaCungCap.DataSource = list;
            }
            dgNhaCungCap.ReadOnly = true;
            dgNhaCungCap.AllowUserToResizeColumns = false;
            dgNhaCungCap.AllowUserToResizeRows = false;
            dgNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
        }

        private void btThemNCC_Click(object sender, EventArgs e)
        {
            frm_ThemNCC form = new frm_ThemNCC();
            form.ShowDialog();
        }

        private void dgNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTimKiemNCC.Text = dgNhaCungCap.SelectedCells[0].OwningRow.Cells["TenNCC"].Value.ToString();
        }
    }
}
