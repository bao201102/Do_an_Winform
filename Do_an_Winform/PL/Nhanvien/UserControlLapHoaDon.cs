﻿using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.DangNhap;
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
    public partial class UserControlLapHoaDon : UserControl
    {
        bool isShowMemId = false;
        SanPhamDTO sp = new SanPhamDTO();
        LoaiSanPhamDTO loaisp = new LoaiSanPhamDTO();
        NhaSanXuatDTO nhasx = new NhaSanXuatDTO();
        List<SanPhamDTO> listSP = new List<SanPhamDTO>();
        List<KhachHangDTO> listKH = new List<KhachHangDTO>();
        KhachHangDTO khachHang = new KhachHangDTO();
        LoaiThanhVienDTO loaitv = new LoaiThanhVienDTO();
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        NhanVienDTO nhanVien = new NhanVienDTO();
        List<HoaDonDTO> listHoaDon = new List<HoaDonDTO>();
        List<ChiTietHoaDonDTO> listCTHD = new List<ChiTietHoaDonDTO>();
        public UserControlLapHoaDon()
        {
            InitializeComponent();
            gridview_Load();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void UserControlLapHoaDon_Load(object sender, EventArgs e)
        {
            listHoaDon = HoaDonBLL.GetAllBill();
            int count = listHoaDon.Count + 1;
            string maHD = "HD" + count.ToString("000");
            txtMaHD.Text = maHD;
            txtMaHD.Visible = false;
            txtSDT.Enabled = false;
            txtTenKH.Enabled = false;
            txtLoaiTV.Enabled = false;
            try
            {
                nhanVien = NhanVienBLL.GetEmployee(frm_NVien.taikhoan1.MaNguoiDung);
            }
            catch (Exception)
            {
            }
            
            if (!DesignMode)
            {
                listSP = SanPhamBLL.GetAllProduct();
                
                foreach (SanPhamDTO sp in listSP)
                {
                    cbTenSP.Items.Add(sp.TenSP);
                }
                lblTenNV.Text = nhanVien.TenNV;
                DateTime curDay = DateTime.Now;
                lblNgayBan.Text = (new DateTime(curDay.Year, curDay.Month, curDay.Day)).ToString("dd / MM / yyyy");
            }
        }
        private void rbThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            listKH = KhachHangBLL.GetAllCustomer();
            isShowMemId = !isShowMemId;
            if(isShowMemId)
            {
                txtSDT.Enabled = true;
                txtTenKH.Enabled = false;
                txtLoaiTV.Enabled = false;
            }
            else
            {
                txtSDT.Enabled = false;
                txtTenKH.Enabled = true;
                txtLoaiTV.Enabled = false;
            }
            
            
        }
        
        public static string TachChuoi(string discount)
        {
            string v = "";
            for(int i = 0; i < discount.Length; i++)
            {
                if(discount[i] == '%')
                {
                    v = discount.Substring(0, i);
                }
            }
            return v;
        }

        private void rbKhachLe_CheckedChanged(object sender, EventArgs e)
        {
            txtTenKH.Enabled = true;
        }
        //Thanh toán
        public void ThemChiTietHD()
        {
            int count = 0;
            for (int i = 0; i < dgvProduct.RowCount; i++)
            {
                ChiTietHoaDonDTO chiTietHD = new ChiTietHoaDonDTO();
                string tenSP = dgvProduct.Rows[i].Cells[0].Value.ToString();
                chiTietHD.MaHD = txtMaHD.Text;
                chiTietHD.MaSP = SanPhamBLL.GetProductEqualsName(tenSP).MaSP;
                chiTietHD.TenSP = tenSP;
                chiTietHD.SoLuong = int.Parse(dgvProduct.Rows[i].Cells[1].Value.ToString());
                chiTietHD.ThanhTien = int.Parse(TachThanhTien(dgvProduct.Rows[i].Cells[4].Value.ToString()));
                chiTietHD.TrangThai = "1";
                if (ChiTietHoaDonBLL.AddNewBillDetail(chiTietHD))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                MessageBox.Show("Thêm chi tiết hóa đơn thành công");
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            if (cbTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
            }
            else if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }
            else
            {
                int totalBuy = int.Parse(TachThanhTien(lblTotalBuy.Text));
                HoaDonDTO hoaDon = new HoaDonDTO();
                listHoaDon = HoaDonDAL.GetAllBill();
                hoaDon.MaHD = txtMaHD.Text;
                DateTime curDay = DateTime.Now;
                hoaDon.NgayTaoHD = (new DateTime(curDay.Year, curDay.Month, curDay.Day));
                try
                {
                    nhanVien = NhanVienBLL.GetEmployee(frm_NVien.taikhoan1.MaNguoiDung);
                }
                catch (Exception)
                {
                }
                hoaDon.MaNV = nhanVien.MaNV;
                if (txtSDT.Text == "")
                {
                    hoaDon.MaKH = null;
                }
                else
                {
                    hoaDon.MaKH = (KhachHangDAL.GetCustomerByPhone(txtSDT.Text)).MaKH;
                }
                hoaDon.ThanhTien = totalBuy;
                hoaDon.TrangThai = "1";
                if (HoaDonDAL.AddNewBill(hoaDon))
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                    ThemChiTietHD();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
        }
        

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private static string TachThanhTien(string thanhTien)
        {
            string v = "";
            for (int i = 0; i < thanhTien.Length; i++)
            {
                if (thanhTien[i] == 'đ')
                {
                    v = thanhTien.Substring(0, i);
                }
            }
            return v;
        }
        public static HoaDonDTO CheckIdBill(List<HoaDonDTO> listHoaDon, string maHD)
        {
            HoaDonDTO hoaDon = new HoaDonDTO();
            for (int i = 0; i < listHoaDon.Count; i++)
            {
                if (listHoaDon[i].MaHD == maHD)
                {
                    hoaDon = listHoaDon[i];
                    break;
                }
            }
            return hoaDon;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtLoaiTV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void btnIn2_Click(object sender, EventArgs e)
        {
            string tenNV = lblTenNV.Text;
            string ngayTao = "";
            string tenKH = txtTenKH.Text;
            string loaiTV = txtLoaiTV.Text;
            if (txtLoaiTV.Text == "")
            {
                loaiTV = "Không";
            }
            frm_XemHoaDon frmHD = new frm_XemHoaDon(txtMaHD.Text, tenNV, ngayTao, tenKH, loaiTV);
            frmHD.Show();
        }
        private DataTable dataTable = new DataTable();
        private void gridview_Load()
        {
            dataTable.Columns.Add("Tên sản phẩm");
            dataTable.Columns.Add("Số lượng");
            dataTable.Columns.Add("Đơn giá");
            dataTable.Columns.Add("Tên nhà sản xuất");
            dataTable.Columns.Add("Thành tiền");
            dgvProduct.DataSource = dataTable;
        }
        int total = 0;
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            total += int.Parse(TachThanhTien(lblTotal2.Text));
            lblTotalBuy.Text = total.ToString() + "đ";
            sp = SanPhamDAL.GetProductByName(cbTenSP.Text);
            nhasx = NhaSanXuatDAL.GetManufacById(sp.MaNhaSX);
            dataTable.Rows.Add(cbTenSP.Text, txtSL.Text, lblPrice2.Text, nhasx.TenNhaSX, lblTotal2.Text);
        }
        int sum;
        private void dgvProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.SelectedRows[0].Cells[4].Value = int.Parse(dgvProduct.SelectedRows[0].Cells[1].Value.ToString())
                * int.Parse(dgvProduct.SelectedRows[0].Cells[2].Value.ToString());

            sum = 0;
            for (int i = 0; i < dgvProduct.RowCount; i++)
            {
                sum += int.Parse(dgvProduct.Rows[i].Cells[4].Value.ToString());
            }
            txtSL.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            lblTotal2.Text = sum.ToString();
        }
        //Cập nhật thông tin khi số lượng thay đổi
        private void txtSL_TextChange(object sender, EventArgs e)
        {
            try
            {
                
                sp = SanPhamBLL.GetProductByName(cbTenSP.Text);
                try
                {
                    lblPrice2.Text = sp.DonGia.ToString() + "đ";
                    if (txtLoaiTV.Text != "")
                    {
                        if (txtLoaiTV.Text == "Đồng")
                        {
                            lblDiscount2.Text = "5%";
                        }
                        else if (txtLoaiTV.Text == "Bạc")
                        {
                            lblDiscount2.Text = "8%";
                        }
                        else if (txtLoaiTV.Text == "Vàng")
                        {
                            lblDiscount2.Text = "10%";
                        }
                        else
                        {
                            lblDiscount2.Text = "12%";
                        }
                    }
                    else
                    {
                        lblDiscount2.Text = "0%";
                    }


                }
                catch
                {

                }
                int tongCong = (int.Parse(txtSL.Text) * sp.DonGia);
                lblSum2.Text = tongCong.ToString() + "đ";
                if (lblDiscount2.Text == "0%")
                {
                    lblTotal2.Text = (tongCong).ToString() + "đ";
                }
                else
                {
                    int discount = int.Parse(TachChuoi(lblDiscount2.Text));
                    int thanhTien = tongCong - (tongCong * discount / 100);
                    lblTotal2.Text = (thanhTien).ToString() + "đ";
                    
                }
            }
            catch { }
        }

        private void cbTenSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                lblPrice2.Text = SanPhamBLL.GetProductByName(cbTenSP.Text).DonGia.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                khachHang = KhachHangBLL.GetCustomerByPhone(txtSDT.Text);
                txtTenKH.Text = khachHang.TenKH;
                txtLoaiTV.Text = LoaiThanhVienDAL.GetTypeMemById(khachHang.MaLoaiTVien).TenLoaiTVien;
            }
            catch
            {

            }
        }
        
    }
}
