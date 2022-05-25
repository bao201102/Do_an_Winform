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

namespace Do_an_Winform.PL.Quanly.QLSP
{
    public partial class frm_Update : Form
    {
        internal string masp;
        public frm_Update()
        {
            InitializeComponent();
        }

        private void frm_Update_Load(object sender, EventArgs e)
        {
            List<NhaSanXuatDTO> nsx = NhaSanXuatBLL.GetAllManufac();
            nsx.RemoveAt(0);
            cbNSX.DataSource = nsx;
            cbNSX.DisplayMember = "TenNhaSX";
            cbNSX.ValueMember = "MaNhaSX";

            List<LoaiSanPhamDTO> lsp = LoaiSanPhamBLL.GetAllCat();
            lsp.RemoveAt(0);
            cbLoaisp.DataSource = lsp;
            cbLoaisp.DisplayMember = "TenLoaiSP";
            cbLoaisp.ValueMember = "MaLoaiSP";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn có muốn hủy cập nhật thông tin sản phẩm ?");
            if (result)
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SanPhamDTO productDTO = new SanPhamDTO();
            productDTO.MaSP = masp;
            productDTO.TenSP = txtTensp.Text;
            productDTO.DonGia = int.Parse(txtDongia.Text);
            productDTO.MaLoaiSP = cbLoaisp.SelectedValue.ToString();
            productDTO.MaNhaSX = cbNSX.SelectedValue.ToString();

            if (txtTensp.Text == "" || txtDongia.Text == "")
            {
                bunifuSnackbar1.Show(this, "Vui lòng nhập đủ thông tin vào ô trống", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {    
                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn sửa thông tin sản phẩm không ?");
                if (result)
                {
                    if (SanPhamBLL.UpdateProduct(productDTO))
                    {
                        bunifuSnackbar1.Show(new frm_QLSP(), "Bạn đã sửa thông tin sản phẩm thành công", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        Close();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn có muốn xóa thông tin sản phẩm không ?");
            if (result)
            {
                if (SanPhamBLL.DeleteProduct(masp))
                {
                    bunifuSnackbar1.Show(new frm_QLSP(), "Bạn đã xóa thông tin sản phẩm thành công", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    Close();
                }
            }
        }
    }
}
