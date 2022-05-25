using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.DangNhap;
using Do_an_Winform.PL.Quanly;
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
    public partial class frm_ThemNV : Form
    { 
        public frm_ThemNV()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = "NV" + NhanVienBLL.CountEmployee().ToString("000");
            nv.TenNV = txtTenNV.Text;
            nv.Email = txtEmailNV.Text;
            nv.DiaChi = txtDiaChiNV.Text;
            nv.SĐT = txtSDTNV.Text;
            nv.GioiTinh = cbGioiTinhNV.Text;
            nv.MaLoaiNV = cbMaLoaiNV.Text;
            nv.TrangThai = "1";
            if (NhanVienBLL.AddEmployee(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
        }

        private void frm_Them_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtMaNV.Text = "NV" + NhanVienBLL.CountEmployee().ToString("000");
            cbGioiTinhNV.Text = "Nam";
            cbMaLoaiNV.Text = "LNV001";
        }

        private void frm_ThemNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn đã hủy thao tác thêm", "Thông báo", MessageBoxButtons.OK);
            Form frm = Application.OpenForms["frm_Quanly"];
            frm.Show();
            this.Hide();
            
        }

        
    }
}
