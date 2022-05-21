using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
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

namespace Do_an_Winform.PL.DangNhap
{
    public partial class frm_Thongtin : Form
    {
        NhanVienDTO emp = new NhanVienDTO();
        LoaiNhanVienDTO empType = new LoaiNhanVienDTO();
        Form mainform = new Form();
        public frm_Thongtin(NhanVienDTO nhanvien, LoaiNhanVienDTO loainhanvien, Form form)
        {
            InitializeComponent();
            emp = nhanvien;
            empType = loainhanvien;
            mainform = form;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void employee_LoadData()
        {
            emp = NhanVienBLL.GetEmployeeById(emp.MaNV);
            txtHoten.Text = emp.TenNV;
            txtEmail.Text = emp.Email;
            txtSDT.Text = emp.SĐT;
            txtDiachi.Text = emp.DiaChi;
            cbGender.Text = emp.GioiTinh;
        }

        private void frm_Profile_Load(object sender, EventArgs e)
        {
            employee_LoadData();
            txtLoaitaikhoan.Text = empType.TenLoaiNV;
            txtLoaitaikhoan.Enabled = false;
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            employee_LoadData();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            NhanVienDTO empDTO = new NhanVienDTO();
            empDTO.MaNV = emp.MaNV;
            empDTO.TenNV = txtHoten.Text;
            empDTO.GioiTinh = cbGender.Text;
            empDTO.Email = txtEmail.Text;
            empDTO.DiaChi = txtDiachi.Text;
            empDTO.SĐT = txtSDT.Text;

            if (txtHoten.Text == "" || txtEmail.Text == "" || txtDiachi.Text == "" || txtSDT.Text == "")
            {
                bunifuSnackbar1.Show(this, "Vui lòng nhập đủ thông tin vào ô trống", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn lưu thông tin này không ?");
                if (result)
                {
                    if (NhanVienBLL.UpdateEmployee(empDTO))
                    {
                        bunifuSnackbar1.Show(mainform, "Bạn đã lưu thông tin mới thành công", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        employee_LoadData();
                    }
                }
            }
        }
    }
}
