using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
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

namespace Do_an_Winform.PL.Quanly
{
    public partial class frm_HDNH : Form
    {
        List<PhieuNhapHangDTO> listpn;
        public frm_HDNH()
        {
            InitializeComponent();
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm mã hóa đơn")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm mã hóa đơn";
                txtSearch.ForeColor = Color.Silver;
            }
        }
        private void frm_HDNH_Load(object sender, EventArgs e)
        {
            //load Date
            DatePickerStartDay.Value = System.DateTime.Now;
            DatePickerEndDay.Value = System.DateTime.Now;

            listpn = PhieuNhapHangBLL.ThongKeTatCaPN(DatePickerStartDay.Value, DatePickerEndDay.Value);
            gvHDNH.DataSource = listpn;
            gvHDNH.Columns[0].HeaderText = "Mã PN";
            gvHDNH.Columns[1].HeaderText = "Ngày tạo PN";
            gvHDNH.Columns[2].HeaderText = "Mã NV";
            gvHDNH.Columns[3].HeaderText = "Mã NCC";
            gvHDNH.Columns[4].HeaderText = "Thành tiền";
            gvHDNH.Columns[5].Visible = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startday, endday;
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday <= startday)
                {
                    bunifuSnackbarHDNH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDNH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            if (txtSearch.Text.Trim() != "")
            {
                PhieuNhapHangDTO pnsearch = new PhieuNhapHangDTO();
                pnsearch.MaPN = txtSearch.Text;

                listpn = PhieuNhapHangBLL.ThongKeTheoMaPN(pnsearch, startday, endday);
                gvHDNH.DataSource = listpn;
            }
            else
            {
                listpn = PhieuNhapHangBLL.ThongKeTatCaPN(startday, endday);
                gvHDNH.DataSource = listpn;
            }
        }
    }
}
