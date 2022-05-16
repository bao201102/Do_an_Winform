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

namespace Do_an_Winform.Report
{
    public partial class frm_BaoCaoHDBH : Form
    {
        public frm_BaoCaoHDBH()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoHDBH_Load(object sender, EventArgs e)
        {
            //load Date
            maskedtxtStartDay.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");
            maskedtxtEndDay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            //load report
            DateTime startday, endday;
            startday = DateTime.ParseExact(maskedtxtStartDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            endday = DateTime.ParseExact(maskedtxtEndDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            List<HoaDonDTO> ds = HoaDonBLL.ThongKeTatCaHD(startday, endday);
            this.rpvHDBH.LocalReport.ReportEmbeddedResource = "Do_an_Winform.rpt_HDBH.rdlc";
            this.rpvHDBH.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("HoaDon_HDBH", ds));
            rpvHDBH.RefreshReport();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime startday, endday;
            startday = DateTime.ParseExact(maskedtxtStartDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            endday = DateTime.ParseExact(maskedtxtEndDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            if (txtSearch.Text.Trim() != "")
            {
                HoaDonDTO hdsearch = new HoaDonDTO();
                hdsearch.MaHD = txtSearch.Text;

                List<HoaDonDTO> ds = HoaDonBLL.ThongKeTheoMaHD(hdsearch, startday, endday);
                this.rpvHDBH.LocalReport.ReportEmbeddedResource = "Do_an_Winform.rpt_HDBH.rdlc";
                this.rpvHDBH.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("HoaDon_HDBH", ds));
                rpvHDBH.RefreshReport();
            }
            else
            {               
                List<HoaDonDTO> ds = HoaDonBLL.ThongKeTatCaHD(startday, endday);
                this.rpvHDBH.LocalReport.ReportEmbeddedResource = "Do_an_Winform.rpt_HDBH.rdlc";
                this.rpvHDBH.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("HoaDon_HDBH", ds));
                rpvHDBH.RefreshReport();
            }
        }
    }
}
