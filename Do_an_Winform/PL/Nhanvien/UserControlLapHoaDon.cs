using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.DangNhap;
using Do_an_Winform.PL.Quanly.BaoCao;
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

            dgvInfoProduct.AllowUserToResizeColumns = false;
            dgvInfoProduct.AllowUserToResizeRows = false;

            taikhoan = frm_NVien.taikhoan;
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
            lblNgayBan.Enabled = false;

            nhanVien = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);

            if (!DesignMode)
            {
                listSP = SanPhamBLL.GetAllProduct();

                foreach (SanPhamDTO sp in listSP)
                {
                    cbTenSP.Items.Add(sp.TenSP);
                }
                lblTenNV.Text = nhanVien.TenNV;
                lblNgayBan.Value = DateTime.Now;
            }
        }

        private void rbThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            listKH = KhachHangBLL.GetAllCustomer();
            isShowMemId = !isShowMemId;
            if (isShowMemId)
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
            for (int i = 0; i < discount.Length; i++)
            {
                if (discount[i] == '%')
                {
                    v = discount.Substring(0, i);
                }
            }
            return v;
        }

        private void rbKhachLe_CheckedChanged(object sender, EventArgs e)
        {
            isShow2 = !isShow2;
            if (isShow2)
            {
                txtTenKH.Enabled = true;
                txtTenKH.Text = "";
            }
            else
            {
                txtTenKH.Enabled = false;
                txtTenKH.Text = "";
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (cbTenSP.Text == "" || txtSL.Text == "")
            {
                bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Vui lòng nhập đủ thông tin",
                                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                int totalBuy = int.Parse(lblTotalBuy.Text);
                HoaDonDTO hoaDon = new HoaDonDTO();
                listHoaDon = HoaDonDAL.GetAllBill();
                hoaDon.MaHD = txtMaHD.Text;
                hoaDon.NgayTaoHD = lblNgayBan.Value;
                try
                {
                    nhanVien = NhanVienBLL.GetEmployee(frm_DSHoaDon.taiKhoan.MaNguoiDung);
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
                    bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Thêm hóa đơn thành công",
                                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    int count = 0;

                    for (int i = 0; i < dgvInfoProduct.RowCount; i++)
                    {
                        ChiTietHoaDonDTO chiTietHD = new ChiTietHoaDonDTO();
                        string tenSP = dgvInfoProduct.Rows[i].Cells[0].Value.ToString();
                        chiTietHD.MaHD = txtMaHD.Text;
                        chiTietHD.MaSP = SanPhamBLL.GetProductByName(tenSP).MaSP;
                        chiTietHD.TenSP = tenSP;
                        chiTietHD.SoLuong = int.Parse(dgvInfoProduct.Rows[i].Cells[1].Value.ToString());
                        chiTietHD.ThanhTien = int.Parse(dgvInfoProduct.Rows[i].Cells[4].Value.ToString());
                        chiTietHD.TrangThai = "1";
                        if (ChiTietHoaDonBLL.AddNewBillDetail(chiTietHD))
                        {
                            count++;
                            if (SanPhamBLL.DecreaseQuantityProduct(chiTietHD))
                            {

                            }
                        }
                    }

                    if (rbThanhVien.Checked == true)
                    {
                        khachHang = KhachHangDAL.GetCustomerByPhone(txtSDT.Text);
                        khachHang.DiemTichLuy += 50;
                        if (khachHang.DiemTichLuy <= 100)
                        {
                            khachHang.MaLoaiTVien = "LTV001";
                        }
                        else if (khachHang.DiemTichLuy > 100 && khachHang.DiemTichLuy <= 200)
                        {
                            khachHang.MaLoaiTVien = "LTV002";
                        }
                        else if (khachHang.DiemTichLuy > 200 && khachHang.DiemTichLuy <= 400)
                        {
                            khachHang.MaLoaiTVien = "LTV003";
                        }
                        else
                        {
                            khachHang.MaLoaiTVien = "LTV004";
                        }
                        if (KhachHangDAL.UpdateInfoCustomer(new KhachHangDTO(khachHang.MaKH, khachHang.TenKH, khachHang.GioiTinh, khachHang.Email, khachHang.SĐT, khachHang.DiaChi, khachHang.MaLoaiTVien, khachHang.TrangThai, khachHang.DiemTichLuy)))
                        {
                            lblReturn_Click(sender, e);
                        }
                    }
                    else
                    {
                        lblReturn_Click(sender, e);
                    }
                }
            }
        }

        private void btnIn2_Click(object sender, EventArgs e)
        {
            btnThanhToan_Click(sender, e);

            string tenNV = lblTenNV.Text;
            string ngayTao = lblNgayBan.Text;
            string tenKH = txtTenKH.Text;
            string loaiTV = txtLoaiTV.Text;
            string giamGia = lblDiscount2.Text;
            if (txtLoaiTV.Text == "")
            {
                loaiTV = "Không";
            }
            frm_XemBaoCao frmHD = new frm_XemBaoCao();
            frmHD.rptHoaDon(txtMaHD.Text, tenNV, ngayTao, tenKH, loaiTV, giamGia);
            frmHD.ShowDialog();
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
            if (txtTenKH.Text == "" || cbTenSP.Text == "" || txtSL.Text == "")
            {
                bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Vui lòng nhập đủ thông tin",
                                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
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
                        int donGia = int.Parse(dgvInfoProduct.Rows[i].Cells[2].Value.ToString());
                        int tongCong = soLuong * donGia;
                        int thanhTien = tongCong - (tongCong * int.Parse(TachChuoi(lblDiscount2.Text)) / 100);
                        dgvInfoProduct.Rows[i].Cells[4].Value = thanhTien.ToString();
                        break;
                    }
                }
                if (count == 0)
                {
                    sp = SanPhamDAL.GetProductByName(cbTenSP.Text);
                    nhasx = NhaSanXuatDAL.GetManufacById(sp.MaNhaSX);
                    dataTable.Rows.Add(cbTenSP.Text, txtSL.Text, lblPrice2.Text, nhasx.TenNhaSX, lblTotal2.Text);

                }
                for (int i = 0; i < dgvInfoProduct.RowCount; i++)
                {
                    try
                    {
                        sum += int.Parse(dgvInfoProduct.Rows[i].Cells[4].Value.ToString());
                    }
                    catch { }

                }
                lblTotalBuy.Text = sum.ToString();
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
                    sum += int.Parse(dgvInfoProduct.Rows[i].Cells[4].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            txtSL.Text = dgvInfoProduct.SelectedRows[0].Cells[1].Value.ToString();
            lblTotalBuy.Text = sum.ToString();
        }

        //Cập nhật thông tin khi số lượng thay đổi
        private void txtSL_TextChange(object sender, EventArgs e)
        {
            try
            {

                sp = SanPhamBLL.GetProductByName(cbTenSP.Text);
                try
                {
                    lblPrice2.Text = sp.DonGia.ToString();
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
                        else if (txtLoaiTV.Text == "Kim cương")
                        {
                            lblDiscount2.Text = "12%";
                        }
                        else
                        {
                            lblDiscount2.Text = "0%";
                        }
                    }
                }
                catch
                {

                }
                int tongCong = (int.Parse(txtSL.Text) * sp.DonGia);
                lblSum2.Text = tongCong.ToString();
                if (lblDiscount2.Text == "0%")
                {
                    lblTotal2.Text = (tongCong).ToString();
                }
                else
                {
                    int discount = int.Parse(TachChuoi(lblDiscount2.Text));
                    int thanhTien = tongCong - (tongCong * discount / 100);
                    lblTotal2.Text = (thanhTien).ToString();

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
            int sum = int.Parse(lblTotalBuy.Text);
            if (dgvInfoProduct.SelectedRows.Count > 0)
            {
                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn xóa sản phẩm này không ?");

                if (result)
                {
                    try
                    {
                        int thanhtien = int.Parse(dgvInfoProduct.SelectedRows[0].Cells[4].Value.ToString());
                        sum -= thanhtien;
                        lblTotalBuy.Text = sum.ToString();
                        dgvInfoProduct.Rows.RemoveAt(dgvInfoProduct.SelectedRows[0].Index);
                    }
                    catch { }

                }
            }
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
