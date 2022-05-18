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
    public partial class frm_ThemKH : Form
    {
        public frm_ThemKH()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.Email = txtEmailKH.Text;
            kh.DiaChi = txtDiaChiKH.Text;
            kh.SĐT = txtSDTKH.Text;
            kh.GioiTinh = cbGioiTinhKH.Text;
            kh.MaLoaiTVien = cbMaLoaiTV.Text;
            kh.DiemTichLuy = 0;
            kh.TrangThai = "1";
            if (KhachHangBLL.AddCustomer(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
        }

        private void frm_Them_Load(object sender, EventArgs e)
        {
            cbGioiTinhKH.Text = "Nam";
            cbMaLoaiTV.Text = "LTV001";
        }

        private void frm_ThemKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn đã hủy thao tác thêm", "Thông báo", MessageBoxButtons.OK);
            Form frm = Application.OpenForms["frm_Quanly"];
            frm.Show();
            this.Hide();
        }
    }
}
