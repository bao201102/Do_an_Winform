using Do_an_Winform.BLL;
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

namespace Do_an_Winform.PL.Thukho
{
    public partial class frm_Nhap : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public frm_Nhap(TaiKhoanDTO user)
        {
            InitializeComponent();
            gridview_Load();
            taikhoan = user;

            gridviewNhap.AllowUserToResizeColumns = false;
            gridviewNhap.AllowUserToResizeRows = false;
            gridviewNhap.MultiSelect = false;
            gridviewNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridviewNhap.Columns[0].ReadOnly = true;
            gridviewNhap.Columns[2].ReadOnly = true;
            gridviewNhap.Columns[3].ReadOnly = true;
            gridviewNhap.Columns[4].ReadOnly = true;
        }

        private void frm_Nhap_Load(object sender, EventArgs e)
        {
            NhanVienDTO emp = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);
            lblTenNV.Text = emp.TenNV;

            cbbNhaCC.DataSource = NhaCungCapBLL.GetNhaCungCap();
            cbbNhaCC.DisplayMember = "TenNCC";
            cbbNhaCC.ValueMember = "MaNCC";

            cbbTenSP.DataSource = SanPhamBLL.GetAllProduct();
            cbbTenSP.DisplayMember = "TenSP";
            cbbTenSP.ValueMember = "MaSP";

            lblDongia.Text = SanPhamBLL.GetProductByName(cbbTenSP.Text.ToString()).DonGia.ToString();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbTenSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblDongia.Text = SanPhamBLL.GetProductByName(cbbTenSP.Text.ToString()).DonGia.ToString();
            txtSoLuong.Text = "";
        }

        private void cbbTenSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDongia.Text = SanPhamBLL.GetProductByName(cbbTenSP.Text.ToString()).DonGia.ToString();
                txtSoLuong.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void txtSoLuong_TextChange(object sender, EventArgs e)
        {
            try
            {
                lblTong.Text = (int.Parse(lblDongia.Text) * int.Parse(txtSoLuong.Text)).ToString();
            }
            catch (Exception)
            {
            }
        }

        private DataTable dataTable = new DataTable();
        private void gridview_Load()
        {
            dataTable.Columns.Add("Tên sản phẩm");
            dataTable.Columns.Add("Số lượng");
            dataTable.Columns.Add("Đơn giá");
            dataTable.Columns.Add("Tên nhà sản xuất");
            dataTable.Columns.Add("Thành tiền");

            gridviewNhap.DataSource = dataTable;
        }

        private int sum = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamDTO spById = SanPhamBLL.GetProductById(cbbTenSP.SelectedValue.ToString());
            NhaSanXuatDTO nsx = NhaSanXuatBLL.GetManufacById(spById.MaNhaSX);
            if (txtSoLuong.Text == "")
            {
                bunifuSnackbar1.Show(this, "Chưa nhập số lượng. Vui lòng thử lại!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                sum += int.Parse(lblTong.Text);
                lblThanhToan.Text = sum.ToString();
                dataTable.Rows.Add(cbbTenSP.Text, txtSoLuong.Text, lblDongia.Text, nsx.TenNhaSX, lblTong.Text);
            }
            txtSoLuong.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridviewNhap.SelectedRows.Count > 0)
            {
                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn xóa sản phẩm này không ?");

                if (result)
                {
                    int thanhtien = int.Parse(gridviewNhap.SelectedRows[0].Cells[4].Value.ToString());
                    sum -= thanhtien;
                    lblThanhToan.Text = sum.ToString();
                    gridviewNhap.Rows.RemoveAt(gridviewNhap.SelectedRows[0].Index);
                }
            }
        }

        private void gridviewNhap_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gridviewNhap.SelectedRows[0].Cells[4].Value = int.Parse(gridviewNhap.SelectedRows[0].Cells[1].Value.ToString())
                * int.Parse(gridviewNhap.SelectedRows[0].Cells[2].Value.ToString());

            sum = 0;
            for (int i = 0; i < gridviewNhap.RowCount; i++)
            {
                sum += int.Parse(gridviewNhap.Rows[i].Cells[4].Value.ToString());
            }
            lblThanhToan.Text = sum.ToString();
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }

        private void lblReturn_MouseHover(object sender, EventArgs e)
        {
            lblReturn.Font = new Font(lblReturn.Font, FontStyle.Underline);
        }

        private void lblReturn_MouseLeave(object sender, EventArgs e)
        {
            lblReturn.Font = new Font(lblReturn.Font, FontStyle.Regular);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienDTO emp = NhanVienBLL.GetEmployee(taikhoan.MaNguoiDung);
            string count = PhieuNhapHangBLL.CountMaPN();

            PhieuNhapHangDTO phieuNhapHangDTO = new PhieuNhapHangDTO();
            phieuNhapHangDTO.MaPN = count;
            phieuNhapHangDTO.NgayTaoPN = DatePicker.Value;
            phieuNhapHangDTO.MaNV = emp.MaNV;
            phieuNhapHangDTO.MaNCC = cbbNhaCC.SelectedValue.ToString();
            phieuNhapHangDTO.ThanhTien = int.Parse(lblThanhToan.Text);

            if (PhieuNhapHangBLL.AddPhieuNhap(phieuNhapHangDTO))
            {

            }

            for (int i = 0; i < gridviewNhap.RowCount; i++)
            {
                ChiTietPhieuNhapDTO chiTiet = new ChiTietPhieuNhapDTO();
                chiTiet.MaPN = count;
                string tensp = gridviewNhap.Rows[i].Cells[0].Value.ToString();
                chiTiet.MaSP = SanPhamBLL.GetProductEqualsName(tensp).MaSP;
                chiTiet.SoLuong = int.Parse(gridviewNhap.Rows[i].Cells[1].Value.ToString());
                string tennsx = gridviewNhap.Rows[i].Cells[3].Value.ToString();
                chiTiet.MaNhaSX = NhaSanXuatBLL.GetManufacByName(tennsx).MaNhaSX;
                chiTiet.ThanhTien = int.Parse(gridviewNhap.Rows[i].Cells[4].Value.ToString());

                if (ChiTietPhieuNhapBLL.AddChiTietPN(chiTiet))
                {

                }

                if (SanPhamBLL.UpdateQuantityProduct(chiTiet))
                {

                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
