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
        int number;
        TaiKhoanDTO dto;
        bool isclicked;
        public frm_ThemNV(int index, TaiKhoanDTO tk)
        {
            InitializeComponent();
            number = index;
            dto = tk;
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
            nv.MaLoaiNV = cbMaLoaiNV.SelectedValue.ToString();
            nv.MaNguoiDung = "US" + NhanVienBLL.CountEmployee().ToString("000");
            nv.TrangThai = "1";
            if (NhanVienBLL.AddEmployee(nv))
            {
                MessageBox.Show("Tạo tài khoản thành công","Chúc mừng");
            }
            isclicked = true;
        }

        private void frm_Them_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtMaNV.Text = "NV" + NhanVienBLL.CountEmployee().ToString("000");
            txtMaNguoiDung.ReadOnly = true;
            txtMaNguoiDung.Text = "US" + NhanVienBLL.CountEmployee().ToString("000");
            cbGioiTinhNV.Text = "Nam";
            cbMaLoaiNV.Enabled = false;
            cbMaLoaiNV.DataSource = LoaiNhanVienBLL.GetAllEmpType();
            cbMaLoaiNV.DisplayMember = "TenLoaiNV";
            cbMaLoaiNV.ValueMember = "MaLoaiNV";
            cbMaLoaiNV.SelectedIndex = number;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isclicked == true)
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Nếu bạn đóng, tài khoản sẽ không được tạo", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (TaiKhoanBLL.RemoveAccount(dto, "US" + NhanVienBLL.CountEmployee().ToString("000")))
                    {
                        MessageBox.Show("Tạo tài khoản thất bại", "Thông báo");
                    }
                    this.Close();
                }
                else if (DialogResult == DialogResult.No)
                {
                    this.Refresh();
                }
            }
        }
    }
}
