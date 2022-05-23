using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.Quanly.BaoCao;
//using Do_an_Winform.PL.Quanly.BaoCao;
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
    public partial class frm_HDBH : Form
    {
        DateTime startday, endday;
        List<HoaDonDTO> listhd;
        public frm_HDBH()
        {
            InitializeComponent();
            gvHDBH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHDBH.ReadOnly = true;
        }
        private void frm_HDBH_Load(object sender, EventArgs e)
        {
            //load Date
            DatePickerStartDay.Value = System.DateTime.Now;
            DatePickerEndDay.Value = System.DateTime.Now;

            listhd = HoaDonBLL.ThongKeTatCaHD(DatePickerStartDay.Value, DatePickerEndDay.Value);
            gvHDBH.DataSource = listhd;
            gvHDBH.Columns[0].HeaderText = "Mã HD";
            gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
            gvHDBH.Columns[2].HeaderText = "Mã NV";
            gvHDBH.Columns[3].HeaderText = "Mã KH";
            gvHDBH.Columns[4].HeaderText = "Thành tiền";
            gvHDBH.Columns[5].Visible = false;
            txtTongCong.Text = HoaDonBLL.ThongKeDoanhThuTheoTDHT(DateTime.Now).ToString();
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday <= startday)
                {
                    bunifuSnackbarHDBH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDBH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            if (txtSearch.Text.Trim() != "")
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;
                HoaDonDTO hdsearch = new HoaDonDTO();
                hdsearch.MaHD = txtSearch.Text;

                listhd = HoaDonBLL.ThongKeTheoMaHD(hdsearch, startday, endday);
                gvHDBH.DataSource = listhd;
                gvHDBH.Columns[0].HeaderText = "Mã HD";
                gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
                gvHDBH.Columns[2].HeaderText = "Mã NV";
                gvHDBH.Columns[3].HeaderText = "Mã KH";
                gvHDBH.Columns[4].HeaderText = "Thành tiền";
                gvHDBH.Columns[5].Visible = false;
                txtTongCong.Text = HoaDonBLL.DoanhThuTheoMaHD(hdsearch, startday, endday).ToString();
            }
            else
            {
                listhd = HoaDonBLL.ThongKeTatCaHD(startday, endday);
                gvHDBH.DataSource = listhd;
                gvHDBH.Columns[0].HeaderText = "Mã HD";
                gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
                gvHDBH.Columns[2].HeaderText = "Mã NV";
                gvHDBH.Columns[3].HeaderText = "Mã KH";
                gvHDBH.Columns[4].HeaderText = "Thành tiền";
                gvHDBH.Columns[5].Visible = false;
                txtTongCong.Text = HoaDonBLL.DoanhThuTatCaHD(startday, endday).ToString();
            }
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday <= startday)
                {
                    bunifuSnackbarHDBH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDBH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            DateTime sday = DatePickerStartDay.Value;
            DateTime eday = DatePickerEndDay.Value;
            if (txtSearch.Text.Trim() != "")
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;
                HoaDonDTO hdsearch = new HoaDonDTO();
                hdsearch.MaHD = txtSearch.Text;

                frm_XemBaoCao frm = new frm_XemBaoCao();
                frm.rpt_HDBH_MaHD(hdsearch.MaHD, sday, eday);
                frm.ShowDialog();
            }
            else
            {
                frm_XemBaoCao frm = new frm_XemBaoCao();
                frm.rpt_HDBH_TatCaHD(sday, eday);
                frm.ShowDialog();
            }
        }

    }
}
