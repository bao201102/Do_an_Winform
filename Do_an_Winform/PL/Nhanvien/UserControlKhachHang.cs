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
        List<LoaiThanhVienDTO> loaiThanhViens = new List<LoaiThanhVienDTO>();
        LoaiThanhVienDTO loaiThanhVien = new LoaiThanhVienDTO();
        public UserControlKhachHang()
        {
            InitializeComponent();
            dgvAllCustomer.AllowUserToResizeColumns = false;
            dgvAllCustomer.AllowUserToResizeRows = false;
            dgvAllCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllCustomer.ReadOnly = true;
        }

        private void UserControlKhachHang_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                //foreach (KhachHangDTO kh in listKhachHang)
                //{
                //    loaiThanhVien = LoaiThanhVienBLL.GetTypeMemById(kh.MaLoaiTVien);
                //    kh.MaLoaiTVien = loaiThanhVien.TenLoaiTVien;
                //    cbTenKhachHang.Items.Add(kh.TenKH);
                //}
                dgvAllCustomer.DataSource = KhachHangBLL.GetAllCustomer();
                dgvAllCustomer.Columns[0].HeaderText = "Mã KH";
                dgvAllCustomer.Columns[1].HeaderText = "Tên KH";
                dgvAllCustomer.Columns[2].HeaderText = "Giới tính";
                dgvAllCustomer.Columns[3].HeaderText = "Email";
                dgvAllCustomer.Columns[4].HeaderText = "SĐT";
                dgvAllCustomer.Columns[5].HeaderText = "Địa chi";
                dgvAllCustomer.Columns[6].HeaderText = "Loại thành viên";
                dgvAllCustomer.Columns[7].HeaderText = "Điểm tích lũy";
            }
        }

        private void cbTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            //foreach (var kh in listKhachHang)
            //{
            //    loaiThanhVien = LoaiThanhVienBLL.GetTypeMemById(kh.MaLoaiTVien);
            //    kh.MaLoaiTVien = loaiThanhVien.TenLoaiTVien;
            //    cbTenKhachHang.Items.Add(kh.TenKH);
            //}
            dgvAllCustomer.DataSource = KhachHangBLL.GetCustomerByName(cbTenKhachHang.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_DKThanhVien frm = new frm_DKThanhVien();
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvAllCustomer.DataSource = KhachHangBLL.GetAllCustomer();
            dgvAllCustomer.Columns[0].HeaderText = "Mã KH";
            dgvAllCustomer.Columns[1].HeaderText = "Tên KH";
            dgvAllCustomer.Columns[2].HeaderText = "Giới tính";
            dgvAllCustomer.Columns[3].HeaderText = "Email";
            dgvAllCustomer.Columns[4].HeaderText = "SĐT";
            dgvAllCustomer.Columns[5].HeaderText = "Địa chi";
            dgvAllCustomer.Columns[6].HeaderText = "Loại thành viên";
            dgvAllCustomer.Columns[7].HeaderText = "Điểm tích lũy";
        }
    }
}
