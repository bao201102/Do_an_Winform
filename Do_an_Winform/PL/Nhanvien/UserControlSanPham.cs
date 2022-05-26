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
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public UserControlSanPham()
        {
            InitializeComponent();
            dgvAllProduct.AllowUserToResizeColumns = false;
            dgvAllProduct.AllowUserToResizeRows = false;
            dgvAllProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllProduct.ReadOnly = true;
        }

        private void UserControlSanPham_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                dgvAllProduct.DataSource = SanPhamBLL.GetProduct();
                this.GanDuLieu();
            }
            cbLoaiSP.DataSource = LoaiSanPhamBLL.GetAllCat();
            cbLoaiSP.DisplayMember = "TenLoaiSP";
            cbLoaiSP.ValueMember = "MaLoaiSP";
            cbThuongHieu.DataSource = NhaSanXuatBLL.GetAllManufac();
            cbThuongHieu.DisplayMember = "TenNhaSX";
            cbThuongHieu.ValueMember = "MaNhaSX";
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
            }
            dgvAllProduct.DataSource = listSanPham;
            this.GanDuLieu();
            dgvAllProduct.Columns[6].Visible = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

            if (cbThuongHieu.SelectedIndex >= 0 && cbThuongHieu.SelectedValue.ToString() != "Tất cả")
            {
                if (cbGia.SelectedIndex >= 0 && cbGia.Text != "")
                {
                    int a = int.Parse(GetMinPrice(cbGia.Text));
                    int b = int.Parse(GetMaxPrice(cbGia.Text));
                    if (cbLoaiSP.SelectedIndex >= 0 && cbLoaiSP.SelectedValue.ToString() != "Tất cả")
                    {

                        dgvAllProduct.DataSource = SanPhamBLL.GetProductByCondition(cbThuongHieu.SelectedValue.ToString(), a, b, cbLoaiSP.SelectedValue.ToString());
                        try
                        {
                            this.GanDuLieu();
                        }
                        catch
                        {
                            bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Không tìm thấy sản phẩm. Vui lòng thử lại",
                                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                        }
                    }
                    else
                    {
                        dgvAllProduct.DataSource = SanPhamBLL.GetProductByCondition(cbThuongHieu.SelectedValue.ToString(), a, b, cbLoaiSP.SelectedValue.ToString());
                        try
                        {
                            this.GanDuLieu();
                        }
                        catch
                        {
                            bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Không tìm thấy sản phẩm. Vui lòng thử lại",
                                                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                        }
                    }
                }
                else
                {
                    if (cbLoaiSP.SelectedIndex < 0 || cbLoaiSP.SelectedValue.ToString() == "Tất cả")
                    {

                        dgvAllProduct.DataSource = SanPhamBLL.GetProductByCondition(cbThuongHieu.SelectedValue.ToString(), 0, 0, cbLoaiSP.SelectedValue.ToString());
                        try
                        {
                            this.GanDuLieu();
                        }
                        catch
                        {
                            bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Không tìm thấy sản phẩm. Vui lòng thử lại",
                                                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                        }
                    }
                    else
                    {
                        dgvAllProduct.DataSource = SanPhamBLL.GetProductByCondition(cbThuongHieu.SelectedValue.ToString(), 0, 0, cbLoaiSP.SelectedValue.ToString());
                        try
                        {
                            this.GanDuLieu();
                        }
                        catch
                        {
                            bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Không tìm thấy sản phẩm. Vui lòng thử lại",
                                                       Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                        }
                    }
                }
            }
            else
            {
                if (cbGia.SelectedIndex >= 0)
                {
                    int a = int.Parse(GetMinPrice(cbGia.Text));
                    int b = int.Parse(GetMaxPrice(cbGia.Text));
                    if (cbLoaiSP.SelectedIndex >= 0 && cbLoaiSP.SelectedValue.ToString() != "Tất cả")
                    {
                        //MessageBox.Show("Giá, Lọai SP");
                        dgvAllProduct.DataSource = SanPhamBLL.GetProductByCondition(cbThuongHieu.SelectedValue.ToString(), a, b, cbLoaiSP.SelectedValue.ToString());
                        try
                        {
                            this.GanDuLieu();
                        }
                        catch
                        {
                            bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Không tìm thấy sản phẩm. Vui lòng thử lại",
                                                      Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Giá");
                        dgvAllProduct.DataSource = SanPhamBLL.GetProductByCondition(cbThuongHieu.SelectedValue.ToString(), a, b, cbLoaiSP.SelectedValue.ToString());
                        try
                        {
                            this.GanDuLieu();
                        }
                        catch
                        {
                            bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Không tìm thấy sản phẩm. Vui lòng thử lại",
                                                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                        }
                    }
                }
                else
                {
                    if (cbLoaiSP.SelectedIndex >= 0 && cbLoaiSP.SelectedValue.ToString() != "Tất cả")
                    {
                        //MessageBox.Show("Loại SP");
                        dgvAllProduct.DataSource = SanPhamBLL.GetProductByCondition(cbThuongHieu.SelectedValue.ToString(), 0, 0, cbLoaiSP.SelectedValue.ToString());
                        try
                        {
                            this.GanDuLieu();
                        }
                        catch
                        {
                            bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Không tìm thấy sản phẩm. Vui lòng thử lại",
                                                     Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                        }
                    }
                    else
                    {
                        bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Vui lòng chọn dữ liệu cần lọc",
                                   Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                    }
                }
            }
        }
        public void GanDuLieu()
        {
            dgvAllProduct.Columns[0].Visible = false;
            dgvAllProduct.Columns[1].HeaderText = "Tên SP";
            dgvAllProduct.Columns[2].HeaderText = "Số lượng";
            dgvAllProduct.Columns[3].HeaderText = "Đơn giá";
            dgvAllProduct.Columns[4].HeaderText = "Loại SP";
            dgvAllProduct.Columns[5].HeaderText = "Thương hiệu";
        }
        public static string GetMinPrice(string priceRange)
        {
            string v = "";
            for (int i = 0; i < priceRange.Length; i++)
            {
                if (priceRange[i] == ' ')
                {
                    v = priceRange.Substring(0, i - 2);
                }
            }
            return v;
        }
        public static string GetMaxPrice(string priceRange)
        {
            string v = "";
            for (int i = 0; i < priceRange.Length; i++)
            {
                if (priceRange[i] == ' ')
                {
                    v = priceRange.Substring(i + 1);
                }
            }
            return v;
        }
    }
}
