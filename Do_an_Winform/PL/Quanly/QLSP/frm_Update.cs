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
    }
}
