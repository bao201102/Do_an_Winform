using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.QLDoiTac
{
    public partial class frm_InsertNCC : Form
    {
        public frm_InsertNCC()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "")
            {
                bunifuSnackbar1.Show(this, "Vui lòng nhập đủ thông tin vào ô trống", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.TenNCC = txtTenNCC.Text;
                ncc.SDT = txtSDT.Text;
                ncc.Email = txtEmail.Text;
                ncc.DiaChi = txtDiaChi.Text;

                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn thêm nhà cung cấp mới không ?");
                if (result)
                {
                    if (NhaCungCapBLL.AddNCC(ncc))
                    {
                        bunifuSnackbar1.Show(new frm_QLSP(), "Bạn đã thêm nhà cung cấp mới thành công", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn có muốn hủy thêm sản phẩm mới ?");
            if (result)
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
