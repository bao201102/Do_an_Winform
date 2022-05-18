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
    public partial class frm_ThemNCC : Form
    {
        public frm_ThemNCC()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            if (NhaCungCapBLL.AddNCC(ncc))
            {
                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void frm_ThemNCC_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn đã hủy thao tác thêm", "Thông báo", MessageBoxButtons.OK);
            Form frm = Application.OpenForms["frm_Quanly"];
            frm.Show();
            this.Hide();
        }
    }
}
