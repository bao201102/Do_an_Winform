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

namespace Do_an_Winform.PL.Nhanvien
{
    public partial class frm_DKThanhVien : Form
    {
        List<object> listKH = new List<object>();
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        public frm_DKThanhVien(TaiKhoanDTO user)
        {
            InitializeComponent();

            taikhoan = user;
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == ""|| cbGioiTinh.Text == ""|| txtEmail.Text == ""|| txtSDT.Text == ""|| txtDiaChi.Text == "")
            {
                bunifuSnackbar1.Show(this, "Vui lòng nhập đủ thông tin vào ô trống", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                listKH = KhachHangBLL.GetAllCustomer();
                int count = listKH.Count + 1;
                string maKH = "KH" + count.ToString("000");
                KhachHangDTO khachHang = new KhachHangDTO(maKH, txtHoTen.Text, cbGioiTinh.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text, "LTV001", "1", 50);

                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn thêm thành viên mới không ?");
                if (result)
                {
                    if (KhachHangBLL.AddNewCustomer(khachHang))
                    {
                        bunifuSnackbar1.Show(new frm_NVien(taikhoan), "Bạn đã thêm khách hàng mới thành công", 
                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        Close();
                    }
                }

            }
        }

        public static string CreateId(List<KhachHangDTO> listKH)
        {
            string maKH = "";
            if (listKH.Count + 1 < 10)
            {
                maKH = $"KH00{listKH.Count + 1}";
            }
            else if (listKH.Count + 1 >= 10 && listKH.Count + 1 < 100)
            {
                maKH = $"KH0{listKH.Count + 1}";
            }
            else
            {
                maKH = $"KH{listKH.Count + 1}";
            }
            return maKH;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn có muốn hủy thêm thành viên ?");
            if (result)
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void frm_DKThanhVien_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }
    }
}
