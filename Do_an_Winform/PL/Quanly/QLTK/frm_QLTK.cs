using Do_an_Winform.DTO;
using Do_an_Winform.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.QLTK
{
    public partial class frm_QLTK : Form
    {
        public frm_QLTK()
        {
            InitializeComponent();
        }

        private void btXuatThongTin_Click(object sender, EventArgs e)
        {
            string name = txtTimKiemTonKho.Text;
            string loai = cbLoaiSP.SelectedValue.ToString();
            if (cbLoaiSP.SelectedIndex == 0)
            {
                List<SanPhamDTO> list = SanPhamBLL.GetAllProductWithConditions(name);
                dgTonKho.DataSource = list;
            }
            else
            {
                List<SanPhamDTO> list = SanPhamBLL.GetProductByMaLoaiWithConditions(name, loai);
                dgTonKho.DataSource = list;
            }

            dgTonKho.ReadOnly = true;
            dgTonKho.AllowUserToResizeColumns = false;
            dgTonKho.AllowUserToResizeRows = false;
            dgTonKho.Columns[0].HeaderText = "Mã sản phẩm";
            dgTonKho.Columns[1].HeaderText = "Tên sản phẩm";
            dgTonKho.Columns[2].HeaderText = "Số lượng";
            dgTonKho.Columns[3].HeaderText = "Đơn giá";
            dgTonKho.Columns[4].HeaderText = "Mã loại";
            dgTonKho.Columns[5].HeaderText = "Mã nhà sản xuất";
            dgTonKho.Columns[6].HeaderText = "Trạng thái";
        }

        private void frm_QLTK_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = LoaiSanPhamBLL.GetAllCat();
            cbLoaiSP.DisplayMember = "TenLoaiSP";
            cbLoaiSP.ValueMember = "MaLoaiSP";
            cbLoaiSP.SelectedIndex = 0;
        }
    }
}
