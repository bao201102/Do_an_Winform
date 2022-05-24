using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.DangNhap;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.QLSP
{
    public partial class frm_QLSP_RP : Form
    {
        public frm_QLSP_RP()
        {
            InitializeComponent();
        }

        private void frm_QLSP_RP_Load(object sender, EventArgs e)
        {
            List<LoaiSanPhamDTO> lsp = LoaiSanPhamBLL.GetAllCat();
            lsp.RemoveAt(0);
            cbLoaisp.DataSource = lsp;
            cbLoaisp.DisplayMember = "TenLoaiSP";
            cbLoaisp.ValueMember = "MaLoaiSP";
            cbLoaisp.SelectedIndex = 0;

            this.reportViewerResult.RefreshReport();
        }

        private void btnXemRP_Click(object sender, EventArgs e)
        {
            if (bunifuToggleSwitch1.Checked == true)
            {
                reportViewerResult.RefreshReport();
                reportViewerResult.LocalReport.DataSources.Clear();
                List<object> products = SanPhamBLL.GetAllProductByCat(cbLoaisp.SelectedValue.ToString());
                reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.QLSP.rpt_DSSP.rdlc";
                reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("DSSP", products));
                reportViewerResult.LocalReport.SetParameters(new ReportParameter("paTenLoai", cbLoaisp.Text));
                reportViewerResult.RefreshReport();
            }
            else
            {
                reportViewerResult.RefreshReport();
                reportViewerResult.LocalReport.DataSources.Clear();
                List<LoaiSanPhamDTO> lsp = LoaiSanPhamBLL.GetAllCat();
                lsp.RemoveAt(0);
                reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.QLSP.rpt_DSSP_Group.rdlc";
                reportViewerResult.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
                reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("LoaiSP", lsp));
                reportViewerResult.RefreshReport();
            }
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            string maloai = e.Parameters["paMaLoai"].Values[0];
            List<object> products = SanPhamBLL.GetAllProductByCat(maloai);
            e.DataSources.Add(new ReportDataSource("DSSP", products));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn muốn thoát chương trình ?");
            if (result)
            {
                this.Close();
            }
        }
    }
}
