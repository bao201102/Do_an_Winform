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

        private void frm_DoiTacNCC_Load(object sender, EventArgs e)
        {
            dgNhaCungCap.DataSource = NhaCungCapBLL.GetAllSupply();
            dgNhaCungCap.ReadOnly = true;
            dgNhaCungCap.AllowUserToResizeColumns = false;
            dgNhaCungCap.AllowUserToResizeRows = false;
            dgNhaCungCap.Columns[0].Visible = false;
            dgNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
        }

        private void btThemNCC_Click(object sender, EventArgs e)
        {
            frm_ThemNCC form = new frm_ThemNCC();
            form.ShowDialog();
            dgNhaCungCap.DataSource = NhaCungCapBLL.GetAllSupply();
        }

        private void txtFind_TextChange(object sender, EventArgs e)
        {
            try
            {
                dgNhaCungCap.DataSource = NhaCungCapBLL.GetSupplyWithName(txtFind.Text);
                dgNhaCungCap.Columns[0].Visible = false;
                dgNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
            }
            catch (Exception)
            {

            }
        }
    }
}
