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
            maskedtxtToday.Value = System.DateTime.Now;

            //Dữ liệu thống kê tháng hiện tại
            DateTime today = maskedtxtToday.Value;
            txtNamTK.Text = DateTime.Now.ToString("yyyy");
            cbQuyTK.SelectedItem = LayQuy(today.Month.ToString()).ToString();
            cbThangTK.SelectedItem = today.Month;
            txtDoanhThu.Text = HoaDonBLL.ThongKeDoanhThuTheoTDHT(today).ToString();
            txtChiPhi.Text = PhieuNhapHangBLL.ThongKeChiPhiTheoTDHT(today).ToString();
            txtLoiNhuan.Text = (double.Parse(txtDoanhThu.Text) - double.Parse(txtChiPhi.Text)).ToString();

            txtDoanhThu.ReadOnly = true;
            txtChiPhi.ReadOnly = true;
            txtLoiNhuan.ReadOnly = true;
        }

        private void cbQuyTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbThangTK.Items.Clear();
            object[] month1quarter = new object[] { 1, 2, 3, "Tất cả" };
            object[] month2quarter = new object[] { 4, 5, 6, "Tất cả" };
            object[] month3quarter = new object[] { 7, 8, 9, "Tất cả" };
            object[] month4quarter = new object[] { 10, 11, 12, "Tất cả" };
            object[] allmonth = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
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
            if (cbHTTK.Text == "Năm")
            {
                cbQuyTK.Enabled = false;
                cbQuyTK.Text = "Tất Cả";

                cbThangTK.Enabled = false;
                cbThangTK.Text = "Tất Cả";
            }
            if (cbHTTK.Text == "Quý")
            {
                cbQuyTK.Enabled = true;
                cbThangTK.Enabled = false;
                cbQuyTK.Items.Remove("Tất cả");
                cbQuyTK.Items.Clear();
                object[] quy = new object[] { 1, 2, 3, 4 };
                cbQuyTK.Items.AddRange(quy);
                cbThangTK.Text = "Tất cả";
            }
            if (cbHTTK.Text == "Tháng" || cbHTTK.Text == "")
            {
                cbThangTK.Text = "";
                cbThangTK.Items.Remove("Tất cả");
                cbThangTK.Enabled = true;
                cbQuyTK.Enabled = false;
                cbQuyTK.Text = "";
                if (cbQuyTK.Text == "")
                {
                    cbThangTK.Items.Clear();
                    object[] allmonth = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    cbThangTK.Items.AddRange(allmonth);
                }
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

        private void btnTK_Click(object sender, EventArgs e)
        {
            chartCanvasTKDT.Clear();
            barChartCP.Data.Clear();
            barChartDT.Data.Clear();
            barChartLN.Data.Clear();

            //THỐNG KÊ
            if (cbHTTK.Text == "")
            {
                    bunifuSnackbarTKDT.Show(this, "Vui lòng chọn hình thức thống kê \nThử lại", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            if (cbHTTK.Text == "Năm")
            {
                txtDoanhThu.Text = HoaDonBLL.ThongKeDoanhThuTheoNam(txtNamTK.Text).ToString();
                txtChiPhi.Text = PhieuNhapHangBLL.ThongKeChiPhiTheoNam(txtNamTK.Text).ToString();
            }
            if (cbHTTK.Text == "Quý")
            {
                txtDoanhThu.Text = HoaDonBLL.ThongKeDoanhThuTheoQuy(cbQuyTK.SelectedItem.ToString(), txtNamTK.Text).ToString();
                txtChiPhi.Text = PhieuNhapHangBLL.ThongKeChiPhiTheoQuy(cbQuyTK.SelectedItem.ToString(), txtNamTK.Text).ToString();
            }
            if (cbHTTK.Text == "Tháng")
            {
                cbQuyTK.Enabled = false;
                txtDoanhThu.Text = HoaDonBLL.ThongKeDoanhThuTheoThang(cbThangTK.Text, txtNamTK.Text).ToString();
                txtChiPhi.Text = PhieuNhapHangBLL.ThongKeChiPhiTheoThang(cbThangTK.Text, txtNamTK.Text).ToString();
            }
            txtLoiNhuan.Text = (double.Parse(txtDoanhThu.Text) - double.Parse(txtChiPhi.Text)).ToString();

            // VẼ BIỂU ĐỒ CỘT SO SÁNH DOANH THU, CHI PHI CỦA MỘT NĂM (12 Tháng)
            if(cbHTTK.Text == "Năm")
            {
                //Doanh Thu
                List<double> profitDataList = new List<double>();
                for (int i = 1; i <= 12; i++)
                {
                    profitDataList.Add(HoaDonBLL.ThongKeDoanhThuTheoThang($"{i}", txtNamTK.Text));
                }
                barChartDT.Data = profitDataList;
                barChartDT.TargetCanvas = chartCanvasTKDT;
                List<Color> profitColors = new List<Color>();
                for (int i = 0; i < profitDataList.Count; i++)
                {
                    profitColors.Add(Color.FromArgb(80, 120, 60));
                }
                barChartDT.BackgroundColor = profitColors;

                //Chi Phí
                List<double> expenseDataList = new List<double>();
                for (int i = 1; i <= 12; i++)
                {
                    expenseDataList.Add(PhieuNhapHangBLL.ThongKeChiPhiTheoThang($"{i}", txtNamTK.Text));
                }
                barChartCP.Data = expenseDataList;
                barChartCP.TargetCanvas = chartCanvasTKDT;
                List<Color> expenseColors = new List<Color>();
                for (int i = 0; i < expenseDataList.Count; i++)
                {
                    expenseColors.Add(Color.FromArgb(10, 110, 60));
                }
                barChartCP.BackgroundColor = expenseColors;              
            }

            // VẼ BIỂU ĐỒ ĐƯỜNG SO SÁNH LỢI NHUẬN CỦA MỘT NĂM (12 Tháng)
            if (cbHTTK.Text == "Năm")
            {
                //Lợi Nhuận
                List<double> salesDataList = new List<double>();
                for (int i = 1; i <= 12; i++)
                {
                    salesDataList.Add(HoaDonBLL.ThongKeDoanhThuTheoThang($"{i}", txtNamTK.Text) - PhieuNhapHangBLL.ThongKeChiPhiTheoThang($"{i}", txtNamTK.Text));
                }
                lineChartLN.Data = salesDataList;
                lineChartLN.TargetCanvas = chartCanvasTKDT;
                lineChartLN.BackgroundColor = Color.Green;
            }

            chartCanvasTKDT.Update();
            chartCanvasTKDT.Refresh();
        }

        private void txtNamTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
