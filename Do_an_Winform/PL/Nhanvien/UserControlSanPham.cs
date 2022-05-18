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
                this.GanDuLieu();
            }
            cbLoaiSP.DataSource = LoaiSanPhamBLL.GetAllCat();
            cbLoaiSP.DisplayMember = "TenLoaiSP";
            cbLoaiSP.ValueMember = "MaLoaiSP";
            cbThuongHieu.DataSource = NhaSanXuatBLL.GetAllManufac();
            cbThuongHieu.DisplayMember = "TenNhaSX";
            cbThuongHieu.ValueMember = "MaNhaSX";
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
            listSanPham = SanPhamBLL.GetProByTxtNameChanged(cbTenSP.Text);
            foreach (SanPhamDTO sp in listSanPham)
            {
                nhasx = NhaSanXuatBLL.GetManufacById(sp.MaNhaSX);
                loaisp = LoaiSanPhamBLL.GetProTypeById(sp.MaLoaiSP);
                sp.MaLoaiSP = loaisp.TenLoaiSP;
                sp.MaNhaSX = nhasx.TenNhaSX;
                cbTenSP.Items.Add(sp.TenSP);
            }
            dgvAllProduct.DataSource = listSanPham;
            dgvAllProduct.Columns[0].Visible = false;
            dgvAllProduct.Columns[1].HeaderText = "Tên SP";
            dgvAllProduct.Columns[2].HeaderText = "Số lượng";
            dgvAllProduct.Columns[3].HeaderText = "Đơn giá";
            dgvAllProduct.Columns[4].HeaderText = "Loại SP";
            dgvAllProduct.Columns[5].HeaderText = "Thương hiệu";
            dgvAllProduct.Columns[6].Visible = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if(cbThuongHieu.SelectedIndex >= 0 && cbThuongHieu.SelectedValue.ToString() != "Tất cả")
            {
                if(cbGia.SelectedIndex >= 0)
                {
                    if(cbLoaiSP.SelectedIndex >= 0 && cbLoaiSP.SelectedValue.ToString() != "Tất cả")
                    {
                        MessageBox.Show("T.hiệu, Giá, Loại SP");
                    }else
                    {
                        MessageBox.Show("T.hiệu, Giá");
                    }
                }else
                {
                    if (cbLoaiSP.SelectedIndex < 0 || cbLoaiSP.SelectedValue.ToString() == "Tất cả")
                    {
                        MessageBox.Show("T.hiệu");
                    }else
                    {
                        MessageBox.Show("T.hiệu, Loại SP");
                    }
                    dgvAllProduct.DataSource = SanPhamBLL.GetProductByManufacId(cbThuongHieu.SelectedValue.ToString());
                    this.GanDuLieu();
                }
            }else
            {
                if(cbGia.SelectedIndex >= 0)
                {
                    if(cbLoaiSP.SelectedIndex >= 0 && cbLoaiSP.SelectedValue.ToString() != "Tất cả")
                    {
                        MessageBox.Show("Giá, Lọai SP");
                    }else
                    {
                        MessageBox.Show("Giá");
                    }
                }else
                {
                    if(cbLoaiSP.SelectedIndex >= 0 && cbLoaiSP.SelectedValue.ToString() != "Tất cả")
                    {
                        MessageBox.Show("Loại SP");
                    }else
                    {
                        MessageBox.Show("Vui lòng chọn dữ liệu cần lọc");
                    }
                }
            }
            //MessageBox.Show(cbGia.Text);
            MessageBox.Show($"Min price: {GetMinPrice(cbGia.Text)}, Max price: {GetMaxPrice(cbGia.Text)}");
        }
        public void GanDuLieu()
        {
            dgvAllProduct.Columns[0].HeaderText = "Tên SP";
            dgvAllProduct.Columns[1].HeaderText = "Số lượng";
            dgvAllProduct.Columns[2].HeaderText = "Đơn giá";
            dgvAllProduct.Columns[3].HeaderText = "Loại SP";
            dgvAllProduct.Columns[4].HeaderText = "Thương hiệu";
        }
        public static int GetMinPrice(string priceRange)
        {
            int a = 0;
            for(int i = 0; i < priceRange.Length ; i++)
            {
                if(priceRange[i] == ' ')
                {
                    int v = int.Parse(priceRange.Substring(0, i - 1));
                    a = v;
                }
            }
            return a;
        }
        public static int GetMaxPrice(string priceRange)
        {
            int b = 0;
            for (int i = 0; i < priceRange.Length; i++)
            {
                if (priceRange[i] == ' ')
                {
                    int v = Int32.Parse(priceRange.Substring(i + 1));
                    b = v;
                }
            }
            return b;
        }
    }
}
