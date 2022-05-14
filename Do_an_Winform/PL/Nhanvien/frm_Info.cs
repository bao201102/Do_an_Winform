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
    public partial class frm_Info : Form
    {
        NhanVienDTO emp = new NhanVienDTO();
        LoaiNhanVienDTO empType = new LoaiNhanVienDTO();
        public frm_Info(NhanVienDTO nhanvien, LoaiNhanVienDTO loaiNV)
        {
            InitializeComponent();
            emp = nhanvien;
            empType = loaiNV;
        }

        private void frm_Info_Load(object sender, EventArgs e)
        {
            txtName.Text = emp.TenNV;
            txtGender.Text = emp.GioiTinh;
            txtPhone.Text = emp.SĐT;
            txtEmail.Text = emp.Email;
            txtAddress.Text = emp.DiaChi;
            txtEmpType.Text = empType.TenLoaiNV;
        }
    }
}
