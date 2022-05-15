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
        LoaiThanhVienDTO loaithanhvien = new LoaiThanhVienDTO();
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
                loaithanhvien = LoaiThanhVienBLL.GetTypeMemById(kh.MaLoaiTVien);
                kh.MaLoaiTVien = loaithanhvien.TenLoaiTVien;
                cbTenKhachHang.Items.Add(kh.TenKH);
                //cbLoaiKH.Items.Add(loaithanhvien.TenLoaiTVien);
            }

            //foreach (KhachHangDTO kh in listKhachHang)
            //{
            //    loaithanhvien = LoaiThanhVienBLL.GetTypeMemById(kh.MaLoaiTVien);
            //    //dgvAllCustomer.Rows.Add(new string[] {
            //    //    kh.MaKH,
            //    //    kh.TenKH,
            //    //    kh.GioiTinh,
            //    //    kh.Email,
            //    //    kh.SĐT,
            //    //    kh.DiaChi,
            //    //    loaithanhvien.TenLoaiTVien
            //    //});
            //    cbTenKhachHang.Items.Add(kh.TenKH);
            //    cbLoaiKH.Items.Add(loaithanhvien.TenLoaiTVien);
            //}
            dgvAllCustomer.DataSource = listKhachHang;
            dgvAllCustomer.Columns[0].HeaderText = "Mã KH";
            dgvAllCustomer.Columns[1].HeaderText = "Tên KH";
            dgvAllCustomer.Columns[2].HeaderText = "Giới tính";
            dgvAllCustomer.Columns[3].HeaderText = "Email";
            dgvAllCustomer.Columns[4].HeaderText = "SĐT";
            dgvAllCustomer.Columns[5].HeaderText = "Địa chỉ";
            dgvAllCustomer.Columns[6].HeaderText = "Loại Thành Viên";
            dgvAllCustomer.Columns[7].Visible = false;
        }

        private void cbTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            listKhachHang = KhachHangBLL.GetCusByTxtNameChanged(cbTenKhachHang.Text);
            foreach (KhachHangDTO kh in listKhachHang)
            {
                loaithanhvien = LoaiThanhVienBLL.GetTypeMemById(kh.MaLoaiTVien);
                kh.MaLoaiTVien = loaithanhvien.TenLoaiTVien;
            }
            //foreach (KhachHangDTO kh in listKhachHang)
            //{
            //    loaithanhvien = LoaiThanhVienBLL.GetTypeMemById(kh.MaLoaiTVien);
            //    dgvAllCustomer.Rows.Add(new string[] {
            //        kh.MaKH,
            //        kh.TenKH,
            //        kh.GioiTinh,
            //        kh.Email,
            //        kh.SĐT,
            //        kh.DiaChi,
            //        loaithanhvien.TenLoaiTVien
            //    });
            //}
            dgvAllCustomer.DataSource = listKhachHang;
        }
    }
}
