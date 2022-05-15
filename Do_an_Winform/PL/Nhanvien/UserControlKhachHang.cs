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
    public partial class UserControlKhachHang : UserControl
    {
        List<KhachHangDTO> listKhachHang = new List<KhachHangDTO>();
        public UserControlKhachHang()
        {
            InitializeComponent();
            dgvAllCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllCustomer.ReadOnly = true;
        }

        private void UserControlKhachHang_Load(object sender, EventArgs e)
        {
            listKhachHang = KhachHangBLL.GetAllCustomer();
            foreach(KhachHangDTO kh in listKhachHang)
            {
                dgvAllCustomer.Rows.Add(new string[] {
                    kh.MaKH,
                    kh.TenKH,
                    kh.GioiTinh,
                    kh.Email,
                    kh.SĐT,
                    kh.DiaChi,
                    kh.MaLoaiTVien
                });
            }
        }
    }
}
