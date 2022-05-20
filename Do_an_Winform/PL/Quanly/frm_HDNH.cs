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
        DateTime startday, endday;
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

        private void txtSearch_OnIconRightClick(object sender, EventArgs e)
        {
            try
            {
                startday = DateTime.ParseExact(maskedtxtStartDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                endday = DateTime.ParseExact(maskedtxtEndDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                if (endday <= startday)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSearch.Text.Trim() != "")
            {
                PhieuNhapHangDTO pnsearch = new PhieuNhapHangDTO();
                pnsearch.MaPN = txtSearch.Text;

                listpn = PhieuNhapHangDAL.ThongKeTheoMaPN(pnsearch, startday, endday);
                gvHDNH.DataSource = listpn;
            }
            else
            {
                listpn = PhieuNhapHangDAL.ThongKeTatCaPN(startday, endday);
                gvHDNH.DataSource = listpn;
            }
        }

        private void frm_HDNH_Load(object sender, EventArgs e)
        {
            //load Tổng
            txtTongCong.Text = "0";
            //load Date
            maskedtxtStartDay.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");
            maskedtxtEndDay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            //load Datagridview
            DateTime startday, endday;
            startday = DateTime.ParseExact(maskedtxtStartDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            endday = DateTime.ParseExact(maskedtxtEndDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            listpn = PhieuNhapHangDAL.ThongKeTatCaPN(startday, endday);
            gvHDNH.DataSource = listpn;
            //auto complete
            AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
            foreach (PhieuNhapHangDTO pn in listpn)
            {
                autocom.Add(pn.MaPN);
            }
            txtSearch.AutoCompleteCustomSource = autocom;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog printdialog = new PrintDialog();
            printdialog.AllowSomePages = true;
            printdialog.ShowHelp = true;
            printdialog.Document = printDocumentHDNH;
            DialogResult result = printdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocumentHDNH.Print();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            printPreviewDialogHDNH.ShowDialog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startday = DateTime.ParseExact(maskedtxtStartDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                endday = DateTime.ParseExact(maskedtxtEndDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                PhieuNhapHangDTO pnsearch = new PhieuNhapHangDTO();
                pnsearch.MaPN = txtSearch.Text;

                listpn = PhieuNhapHangDAL.ThongKeTheoMaPN(pnsearch, startday, endday);
                gvHDNH.DataSource = listpn;
            }
        }
    }
}
