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

namespace Do_an_Winform.PL.Thukho
{
    public partial class frm_Xuat : Form
    {
        public frm_Xuat()
        {
            InitializeComponent();
        }

        private void frm_Xuat_Load(object sender, EventArgs e)
        {
            cbbNhaCC.DataSource = NhaCungCapBLL.GetNhaCungCap();
            cbbNhaCC.DisplayMember = "TenNCC";
            cbbNhaCC.ValueMember = "MaNCC";

            cbbTenSP.DataSource = SanPhamBLL.GetProduct();
            cbbTenSP.DisplayMember = "TenSP";
            cbbTenSP.ValueMember = "MaSP";
        }


        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
