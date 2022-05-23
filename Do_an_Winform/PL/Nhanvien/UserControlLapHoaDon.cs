using Do_an_Winform.BLL;
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
        bool isShow2 = false;
        SanPhamDTO sp = new SanPhamDTO();
        LoaiSanPhamDTO loaisp = new LoaiSanPhamDTO();
        NhaSanXuatDTO nhasx = new NhaSanXuatDTO();
        List<SanPhamDTO> listSP = new List<SanPhamDTO>();
        List<object> listKH = new List<object>();
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
            dgvInfoProduct.MultiSelect = false;
            dgvInfoProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfoProduct.Columns[0].ReadOnly = true;
            dgvInfoProduct.Columns[2].ReadOnly = true;
            dgvInfoProduct.Columns[3].ReadOnly = true;
            dgvInfoProduct.Columns[4].ReadOnly = true;
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
                txtTenKH.Text = "";
                txtSDT.Text = "";
                txtLoaiTV.Text = "";
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
            isShow2 = !isShow2;
            if(isShow2)
            {
               txtTenKH.Enabled = true;
               txtTenKH.Text = "";
            }else
            {
               txtTenKH.Enabled = false;
               txtTenKH.Text = "";
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
                    int count = 0;
                    
                    for (int i = 0; i < dgvInfoProduct.RowCount; i++)
                    {
                        ChiTietHoaDonDTO chiTietHD = new ChiTietHoaDonDTO();
                        try
                        {
                            string tenSP = dgvInfoProduct.Rows[i].Cells[0].Value.ToString();
                            chiTietHD.MaHD = txtMaHD.Text;
                            chiTietHD.MaSP = SanPhamBLL.GetProductByName(tenSP).MaSP;
                            chiTietHD.TenSP = tenSP;
                            chiTietHD.SoLuong = int.Parse(dgvInfoProduct.Rows[i].Cells[1].Value.ToString());
                            chiTietHD.ThanhTien = int.Parse(TachThanhTien(dgvInfoProduct.Rows[i].Cells[4].Value.ToString()));
                            chiTietHD.TrangThai = "1";
                            if (ChiTietHoaDonBLL.AddNewBillDetail(chiTietHD))
                            {
                                count++;
                            }
                        }
                        catch { }
                    }
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm chi tiết hóa đơn thành công");
                    }
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

        private void label18_Click(object sender, EventArgs e)
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
            string ngayTao = lblNgayBan.Text;
            string tenKH = txtTenKH.Text;
            string loaiTV = txtLoaiTV.Text;
            string giamGia = lblDiscount2.Text;
            if (txtLoaiTV.Text == "")
            {
                loaiTV = "Không";
            }
            frm_XemHoaDon frmHD = new frm_XemHoaDon(txtMaHD.Text, tenNV, ngayTao, tenKH, loaiTV, giamGia);
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
            dgvInfoProduct.DataSource = dataTable;
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng");
            }else if(cbTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
            }else if(txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }else
            {
                int sum = 0;
                int count = 0;
                for (int i = 0; i < dgvInfoProduct.RowCount; i++)
                {
                    if (cbTenSP.Text == dgvInfoProduct.Rows[i].Cells[0].Value.ToString())
                    {
                        count++;
                        int soLuong = int.Parse(dgvInfoProduct.Rows[i].Cells[1].Value.ToString());
                        soLuong = soLuong + 1;
                        dgvInfoProduct.Rows[i].Cells[1].Value = soLuong.ToString();
                        int donGia = int.Parse(TachThanhTien(dgvInfoProduct.Rows[i].Cells[2].Value.ToString()));
                        int tongCong = soLuong * donGia;
                        int thanhTien = tongCong - (tongCong * int.Parse(TachChuoi(lblDiscount2.Text)) / 100);
                        dgvInfoProduct.Rows[i].Cells[4].Value = thanhTien.ToString() + "đ";
                        break;
                    }
                }
                if (count == 0)
                {
                    //sum += int.Parse(TachThanhTien(lblTotal2.Text));
                    //lblTotalBuy.Text = sum.ToString() + "đ";
                    sp = SanPhamDAL.GetProductByName(cbTenSP.Text);
                    nhasx = NhaSanXuatDAL.GetManufacById(sp.MaNhaSX);
                    dataTable.Rows.Add(cbTenSP.Text, txtSL.Text, lblPrice2.Text, nhasx.TenNhaSX, lblTotal2.Text);

                }
                for (int i = 0; i < dgvInfoProduct.RowCount; i++)
                {
                    try
                    {
                        sum += int.Parse(TachThanhTien(dgvInfoProduct.Rows[i].Cells[4].Value.ToString()));
                    }
                    catch { }

                }
                //MessageBox.Show(sum.ToString() + "đ");
                //txtSL.Text = dgvInfoProduct.SelectedRows[0].Cells[1].Value.ToString();
                //lblTotal2.Text = sum.ToString() + "đ";
                lblTotalBuy.Text = sum.ToString() + "đ";
            }
        }
        private void dgvInfoProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int soLuong = int.Parse(dgvInfoProduct.SelectedRows[0].Cells[1].Value.ToString());
            int donGia = int.Parse(dgvInfoProduct.SelectedRows[0].Cells[2].Value.ToString());
            int chietKhau = int.Parse(TachChuoi(lblDiscount2.Text));
            int tongCong = soLuong * donGia;
            int thanhTien = tongCong - (tongCong * chietKhau / 100);
            dgvInfoProduct.SelectedRows[0].Cells[4].Value = thanhTien;
            int sum = 0;
            for (int i = 0; i < dgvInfoProduct.RowCount; i++)
            {
                try
                {
                    sum += int.Parse(TachThanhTien(dgvInfoProduct.Rows[i].Cells[4].Value.ToString()));
                }
                catch { }

            }
            txtSL.Text = dgvInfoProduct.SelectedRows[0].Cells[1].Value.ToString();
            lblTotal2.Text = sum.ToString() + "đ";
            lblTotalBuy.Text = sum.ToString() + "đ";
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

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(TachThanhTien(lblTotalBuy.Text));
            if (dgvInfoProduct.SelectedRows.Count > 0)
            {
                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn xóa sản phẩm này không ?");

                if (result)
                {
                    try
                    {
                        int thanhtien = int.Parse(TachThanhTien(dgvInfoProduct.SelectedRows[0].Cells[4].Value.ToString()));
                        sum -= thanhtien;
                        lblTotalBuy.Text = sum.ToString() + "đ";
                        dgvInfoProduct.Rows.RemoveAt(dgvInfoProduct.SelectedRows[0].Index);
                    }catch { }
                    
                }
            }
        }

        
    }
}
