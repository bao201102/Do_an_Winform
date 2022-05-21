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

namespace Do_an_Winform.PL.DangNhap
{
    public partial class frm_Thongtin : Form
    {
        NhanVienDTO emp = new NhanVienDTO();
        LoaiNhanVienDTO empType = new LoaiNhanVienDTO();
        public frm_Thongtin(NhanVienDTO nhanvien, LoaiNhanVienDTO loainhanvien)
        {
            InitializeComponent();
            emp = nhanvien;
            empType = loainhanvien;

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frm_Profile_Load(object sender, EventArgs e)
        { 
            txtHoten.Text = emp.TenNV;
            txtEmail.Text = emp.Email;
            txtSDT.Text = emp.SĐT;
            txtDiachi.Text = emp.DiaChi;
            cbGender.Text = emp.GioiTinh;
            txtLoaitaikhoan.Text = empType.TenLoaiNV;
            txtLoaitaikhoan.Enabled = false;
        }
    }
}
