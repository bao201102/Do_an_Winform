using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Nhanvien
{
    public partial class UserControlKhachHang : UserControl
    {
        public UserControlKhachHang()
        {
            InitializeComponent();
        }

        private void cbKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (cbKhachHang.SelectedIndex < 0)
            {
                cbKhachHang.Text = "Tìm kiếm khách hàng";
            }
            else
            {
                cbKhachHang.Text = cbKhachHang.SelectedText;
            }
        }
    }
}
