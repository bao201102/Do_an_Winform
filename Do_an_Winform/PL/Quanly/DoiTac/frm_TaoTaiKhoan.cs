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

namespace Do_an_Winform.PL.Quanly.DoiTac
{
    public partial class frm_TaoTaiKhoan : Form
    {
        TaiKhoanDTO tk = new TaiKhoanDTO();
        public frm_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btTaoTK_Click(object sender, EventArgs e)
        {
            tk.UserName = txtTaiKhoan.Text;
            tk.MatKhau = txtMatKhau.Text;
            tk.MaLoaiNV = cbMaLoaiNV.SelectedValue.ToString();
            if (TaiKhoanBLL.AddAccount(tk))
            {
                MessageBox.Show("Cập nhật thông tin để hoàn tất tạo tài khoản","Thông báo");
                frm_ThemNV form = new frm_ThemNV(cbMaLoaiNV.SelectedIndex,tk);
                form.ShowDialog();
                this.Close();
            }
        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cbMaLoaiNV.DataSource = LoaiNhanVienBLL.GetAllEmpType();
            cbMaLoaiNV.ValueMember = "MaLoaiNV";
            cbMaLoaiNV.DisplayMember = "TenLoaiNV";
            cbMaLoaiNV.SelectedIndex = 0;
        }
    }
}
