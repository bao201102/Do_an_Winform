using System;
using Do_an_Winform.PL.DangNhap;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.QLSP
{
    public partial class frm_Insert : Form
    {
        public frm_Insert()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn hủy thêm sản phẩm mới ?");
            if (result)
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }
    }
}
