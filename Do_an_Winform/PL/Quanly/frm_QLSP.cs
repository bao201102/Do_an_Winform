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

namespace Do_an_Winform.PL.Quanly
{
    public partial class frm_QLSP : Form
    {
        public frm_QLSP()
        {
            InitializeComponent();
        }

        private void frm_QLSP_Load(object sender, EventArgs e)
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
    }
}
