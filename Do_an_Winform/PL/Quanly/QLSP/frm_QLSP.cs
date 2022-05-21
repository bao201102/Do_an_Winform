using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.Quanly.QLSP;
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
    public partial class frm_QLSP : Form
    {
        public frm_QLSP()
        {
            InitializeComponent();
        }

        internal void frm_QLSP_Load(object sender, EventArgs e)
        {
            cbLoaisp.DataSource = LoaiSanPhamBLL.GetAllCat();
            cbLoaisp.DisplayMember = "TenLoaiSP";
            cbLoaisp.ValueMember = "MaLoaiSP";
            cbLoaisp.SelectedIndex = 0;

            dgvDSSP.DataSource = SanPhamBLL.GetProduct();
            dgvDSSP.Columns[0].HeaderText = "Tên sản phẩm";
            dgvDSSP.Columns[1].Visible = false;
            dgvDSSP.Columns[2].HeaderText = "Đơn giá";
            dgvDSSP.Columns[3].HeaderText = "Tên loại";
            dgvDSSP.Columns[4].HeaderText = "Nhà sản xuất";
        }

        private void cbLoaisp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbLoaisp.SelectedIndex == 0)
            {
                dgvDSSP.DataSource = SanPhamBLL.GetProduct();
            }
            else
            {
                dgvDSSP.DataSource = SanPhamBLL.GetAllProductByCat(cbLoaisp.SelectedValue.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frm_Insert form = new frm_Insert();
            form.ShowDialog();
            dgvDSSP.DataSource = SanPhamBLL.GetProduct();
        }

        private void txtFind_TextChange(object sender, EventArgs e)
        {
            try
            {
                dgvDSSP.DataSource = SanPhamBLL.GetAllProductByName(txtFind.Text);
            }
            catch (Exception)
            {

            }
        }

        private void dgvDSSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Update form = new frm_Update();
            form.txtTensp.Text = dgvDSSP.CurrentRow.Cells[0].Value.ToString();
            form.txtDongia.Text = dgvDSSP.CurrentRow.Cells[2].Value.ToString();
            form.cbLoaisp.SelectedText = dgvDSSP.CurrentRow.Cells[3].Value.ToString();
            form.cbNSX.SelectedText = dgvDSSP.CurrentRow.Cells[4].Value.ToString();
            form.ShowDialog();
        }
    }
}
