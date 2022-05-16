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
    public partial class UserControlLapHoaDon : UserControl
    {
        SanPhamDTO sp = new SanPhamDTO();
        LoaiSanPhamDTO loaisp = new LoaiSanPhamDTO();
        NhaSanXuatDTO nhasx = new NhaSanXuatDTO();
        List<SanPhamDTO> listSP = new List<SanPhamDTO>();
        public UserControlLapHoaDon()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlLapHoaDon_Load(object sender, EventArgs e)
        {
            listSP = SanPhamBLL.GetAllProduct();
            foreach(SanPhamDTO sp in listSP)
            {
                cbMaSP.Items.Add(sp.MaSP);
            }
            txtDonGia.Enabled = false;
            txtTenSP.Enabled = false;
            txtLoaiSP.Enabled = false;
            txtThuongHieu.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sp = SanPhamBLL.GetProductById(cbMaSP.Text);
            loaisp = LoaiSanPhamBLL.GetProTypeById(sp.MaLoaiSP);
            nhasx = NhaSanXuatBLL.GetManufacById(sp.MaNhaSX);
            txtDonGia.Enabled = true;
            txtTenSP.Enabled = true;
            txtLoaiSP.Enabled = true;
            txtThuongHieu.Enabled = true;
            txtTenSP.Text = sp.TenSP;
            txtDonGia.Text = sp.DonGia.ToString();
            txtLoaiSP.Text = loaisp.TenLoaiSP;
            txtThuongHieu.Text = nhasx.TenNhaSX;
        }
    }
}
