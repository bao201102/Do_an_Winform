using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
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

namespace Do_an_Winform.PL.Quanly
{
    public partial class frm_HDNH : Form
    {
        DateTime startday, endday;
        List<PhieuNhapHangDTO> listpn;
        public frm_HDNH()
        {
            InitializeComponent();
            gvHDNH.AllowUserToResizeColumns = false;
            gvHDNH.AllowUserToResizeRows = false;
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
                txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        private void frm_HDNH_Load(object sender, EventArgs e)
        {
            //auto complete
            List<object> listmapn = PhieuNhapHangBLL.LayTatCaMaPN();
            AutoCompleteStringCollection automapn = new AutoCompleteStringCollection();
            foreach (object i in listmapn)
            {
                automapn.Add(i.ToString());
                //MessageBox.Show(i.ToString());
            }
            txtSearch.AutoCompleteCustomSource = automapn;
            
            //load date
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
            txtTongCong.Text = PhieuNhapHangBLL.ThongKeChiPhiTheoTDHT(DateTime.Now).ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
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
                gvHDNH.Columns[0].HeaderText = "Mã PN";
                gvHDNH.Columns[1].HeaderText = "Ngày tạo PN";
                gvHDNH.Columns[2].HeaderText = "Mã NV";
                gvHDNH.Columns[3].HeaderText = "Mã NCC";
                gvHDNH.Columns[4].HeaderText = "Thành tiền";
                gvHDNH.Columns[5].Visible = false;
                txtTongCong.Text = PhieuNhapHangBLL.ChiPhiTheoMaPN(pnsearch, startday, endday).ToString();
            }
            else
            {
                listpn = PhieuNhapHangBLL.ThongKeTatCaPN(startday, endday);
                gvHDNH.DataSource = listpn;
                gvHDNH.Columns[0].HeaderText = "Mã PN";
                gvHDNH.Columns[1].HeaderText = "Ngày tạo PN";
                gvHDNH.Columns[2].HeaderText = "Mã NV";
                gvHDNH.Columns[3].HeaderText = "Mã NCC";
                gvHDNH.Columns[4].HeaderText = "Thành tiền";
                gvHDNH.Columns[5].Visible = false;
                txtTongCong.Text = PhieuNhapHangBLL.ThongKeTatCaPN(startday, endday).ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday < startday)
                {
                    bunifuSnackbarHDNH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDNH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            //Kiểm tra txtSearch có phải là số hay không?
            int Result;
            bool isSuccess;

            isSuccess = int.TryParse(txtSearch.Text, out Result);
            if (isSuccess == true)
            {
                int mapn = int.Parse(txtSearch.Text);
                string s = "HD" + mapn.ToString("000");
                PhieuNhapHangDTO pnsearch = new PhieuNhapHangDTO();
                pnsearch.MaPN = s;
                listpn = PhieuNhapHangBLL.ThongKeTheoMaPN(pnsearch, startday, endday);
                gvHDNH.DataSource = listpn;
                gvHDNH.Columns[0].HeaderText = "Mã HD";
                gvHDNH.Columns[1].HeaderText = "Ngày lập HD";
                gvHDNH.Columns[2].HeaderText = "Mã NV";
                gvHDNH.Columns[3].HeaderText = "Mã KH";
                gvHDNH.Columns[4].HeaderText = "Thành tiền";
                gvHDNH.Columns[5].Visible = false;
                txtTongCong.Text = PhieuNhapHangBLL.ChiPhiTheoMaPN(pnsearch, startday, endday).ToString();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            PhieuNhapHangDTO pnsearch = new PhieuNhapHangDTO();
            pnsearch.MaPN = txtSearch.Text;
            listpn = PhieuNhapHangBLL.ThongKeTheoMaPN(pnsearch, startday, endday);
            gvHDNH.DataSource = listpn;
            gvHDNH.Columns[0].HeaderText = "Mã HD";
            gvHDNH.Columns[1].HeaderText = "Ngày lập HD";
            gvHDNH.Columns[2].HeaderText = "Mã NV";
            gvHDNH.Columns[3].HeaderText = "Mã KH";
            gvHDNH.Columns[4].HeaderText = "Thành tiền";
            gvHDNH.Columns[5].Visible = false;
            txtTongCong.Text = PhieuNhapHangBLL.ChiPhiTheoMaPN(pnsearch, startday, endday).ToString();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday < startday)
                {
                    bunifuSnackbarHDNH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDNH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            DateTime sday = DatePickerStartDay.Value;
            DateTime eday = DatePickerEndDay.Value;
            frm_XemBaoCao frm = new frm_XemBaoCao();
            frm.rpt_HDNH_TatCaPN(sday, eday);
            frm.ShowDialog();
        }
    }
}
