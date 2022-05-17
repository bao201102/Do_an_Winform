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

namespace Do_an_Winform.PL.Nhanvien
{
    public partial class UserControlSanPham : UserControl
    {
        List<SanPhamDTO> listSanPham = new List<SanPhamDTO>();
        List<object> listSP = new List<object>();
        NhaSanXuatDTO nhasx = new NhaSanXuatDTO();
        LoaiSanPhamDTO loaisp = new LoaiSanPhamDTO();
        public UserControlSanPham()
        {
            InitializeComponent();
            dgvAllProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllProduct.ReadOnly = true;
        }

        private void UserControlSanPham_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                listSanPham = SanPhamBLL.GetProByTxtNameChanged(cbTenSP.Text);
                foreach (SanPhamDTO sp in listSanPham)
                {
                    cbTenSP.Items.Add(sp.TenSP);
                }
                dgvAllProduct.DataSource = SanPhamBLL.GetProduct();
                dgvAllProduct.Columns[0].HeaderText = "Tên SP";
                dgvAllProduct.Columns[1].HeaderText = "Số lượng";
                dgvAllProduct.Columns[2].HeaderText = "Đơn giá";
                dgvAllProduct.Columns[3].HeaderText = "Loại SP";
                dgvAllProduct.Columns[4].HeaderText = "Thương hiệu";
            }         

            //listSanPham = SanPhamBLL.GetProduct();
            //foreach (SanPhamDTO sp in listSanPham)
            //{
            //    nhasx = NhaSanXuatBLL.GetManufacById(sp.MaNhaSX);
            //    loaisp = LoaiSanPhamBLL.GetProTypeById(sp.MaLoaiSP);
            //    sp.MaLoaiSP = loaisp.TenLoaiSP;
            //    sp.MaNhaSX = nhasx.TenNhaSX;
            //    cbTenSP.Items.Add(sp.TenSP);
            //}
            //dgvAllProduct.DataSource = listSanPham;
            //dgvAllProduct.Columns[0].HeaderText = "Mã SP";
            //dgvAllProduct.Columns[1].HeaderText = "Tên SP";
            //dgvAllProduct.Columns[2].Visible = false;
            //dgvAllProduct.Columns[3].HeaderText = "Đơn giá";
            //dgvAllProduct.Columns[4].HeaderText = "Loại SP";
            //dgvAllProduct.Columns[5].HeaderText = "Thương hiệu";
            //dgvAllProduct.Columns[6].Visible = false;

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cbTenSP_TextChanged(object sender, EventArgs e)
        {
            //listSanPham = SanPhamBLL.GetProByTxtNameChanged(cbTenSP.Text);
            //foreach (SanPhamDTO sp in listSanPham)
            //{
            //    cbTenSP.Items.Add(sp.TenSP);
            //}
            listSP = SanPhamBLL.GetAllProductByName(cbTenSP.Text);
            dgvAllProduct.DataSource = listSP;
            //dgvAllProduct.Columns[0].Visible = false;
            //dgvAllProduct.Columns[0].HeaderText = "Tên SP";
            //dgvAllProduct.Columns[1].HeaderText = "Số lượng";
            //dgvAllProduct.Columns[2].HeaderText = "Đơn giá";
            //dgvAllProduct.Columns[3].HeaderText = "Loại SP";
            //dgvAllProduct.Columns[4].HeaderText = "Thương hiệu";
            //dgvAllProduct.Columns[6].Visible = false;
        }
    }
}
