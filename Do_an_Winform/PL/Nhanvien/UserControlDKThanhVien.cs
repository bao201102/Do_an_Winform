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
    public partial class UserControlDKThanhVien : UserControl
    {
        List<KhachHangDTO> listKH = new List<KhachHangDTO>();
        public UserControlDKThanhVien()
        {
            InitializeComponent();
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
            }else if(cbGioiTinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giới tính");
            }else if(txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng email");
            }else if(txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
            }else if(txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
            }else
            {
                listKH = KhachHangBLL.GetAllCustomer();
                KhachHangDTO khachHang = new KhachHangDTO();
                if(listKH.Count + 1 < 10)
                {
                    MessageBox.Show($"KH00{listKH.Count + 1}");
                }else if(listKH.Count + 1 >= 10 && listKH.Count + 1 < 100)
                {
                    MessageBox.Show($"KH0{listKH.Count + 1}");
                }else
                {
                    MessageBox.Show($"KH{listKH.Count + 1}");
                }
                //MessageBox.Show($"KH{listKH.Count + 1}");
            }
        }
        public static string CreateId(List<KhachHangDTO> listKH)
        {
            return "KH" + listKH.Count + 1;    
        }
    }
}
