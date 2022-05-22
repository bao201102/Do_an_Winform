using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly
{
    public partial class frm_TKDT : Form
    {
        public frm_TKDT()
        {
            InitializeComponent();
        }
        private void frm_TKDT_Load(object sender, EventArgs e)
        {
            maskedtxtToday.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");

            //Dữ liệu thống kê tháng hiện tại
            DateTime today = DateTime.ParseExact(maskedtxtToday.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            txtNamTK.Text = DateTime.Now.ToString("yyyy");
            cbQuyTK.SelectedItem = LayQuy(today.Month.ToString()).ToString();
            cbThangTK.SelectedItem = today.Month;
            txtDoanhThu.Text = HoaDonDAL.ThongKeDoanhThuTheoTDHT(today).ToString();
        }
        private void cbQuyTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbThangTK.Items.Clear();
            object[] month1quarter = new object[] { 1, 2, 3, "Tất cả" };
            object[] month2quarter = new object[] { 4, 5, 6, "Tất cả" };
            object[] month3quarter = new object[] { 7, 8, 9, "Tất cả" };
            object[] month4quarter = new object[] { 10, 11, 12, "Tất cả" };
            object[] allmonth = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            if (cbQuyTK.SelectedItem == "1")
            {
                cbThangTK.Items.AddRange(month1quarter);
            }
            if (cbQuyTK.SelectedItem == "2")
            {
                cbThangTK.Items.AddRange(month2quarter);
            }
            if (cbQuyTK.SelectedItem == "3")
            {
                cbThangTK.Items.AddRange(month3quarter);
            }
            if (cbQuyTK.SelectedItem == "4")
            {
                cbThangTK.Items.AddRange(month4quarter);
            }
            if (cbQuyTK.Text == "")
            {
                cbThangTK.Items.AddRange(allmonth);
            }
        }
        private void cbHTTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbHTTK.Text == "Năm")
            {
                cbQuyTK.Enabled = false;
                cbQuyTK.Text = "Tất Cả";

                cbThangTK.Enabled = false;
                cbThangTK.Text = "Tất Cả";

                txtDoanhThu.Text = HoaDonBLL.ThongKeDoanhThuTheoNam(txtNamTK.Text).ToString();
            }
            if (cbHTTK.Text == "Quý")
            {
                cbQuyTK.Items.Remove("Tất cả");
                cbThangTK.Enabled = false;
                cbQuyTK.Text = cbQuyTK.SelectedItem.ToString();
                cbThangTK.Text = "Tất cả";

                txtDoanhThu.Text = HoaDonBLL.ThongKeDoanhThuTheoQuy(cbQuyTK.SelectedItem.ToString(), txtNamTK.Text).ToString();
            }
            if (cbHTTK.Text == "Tháng")
            {
                cbQuyTK.Text = "";
                if(cbQuyTK.Text == "")
                {
                    cbThangTK.Items.Clear();
                    object[] allmonth = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    cbThangTK.Items.AddRange(allmonth);
                }
                cbQuyTK.Enabled = false;
                //txtDoanhThu.Text = HoaDonBLL.ThongKeDoanhThuTheoThang(cbThangTK.Text, txtNamTK.Text).ToString();
            }
        }
        public int LayQuy(string month)
        {
            if (month == "1" || month == "2" || month == "3") return 1;
            else if (month == "4" || month == "5" || month == "6") return 2;
            else if (month == "7" || month == "8" || month == "9") return 3;
            else if (month == "10" || month == "11" || month == "12") return 4;
            return 0;
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {

        }
        private void btnTK_Click(object sender, EventArgs e)
        {

        }
    }
}
