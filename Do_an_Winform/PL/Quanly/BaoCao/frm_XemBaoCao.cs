using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
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

namespace Do_an_Winform.PL.Quanly.BaoCao
{
    public partial class frm_XemBaoCao : Form
    {
        public frm_XemBaoCao()
        {
            InitializeComponent();
        }

        private void frm_XemBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewerResult.RefreshReport();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void rpt_Nhap(PhieuNhapHangDTO phieuNhap, string tenncc,string nhanVien)
        {
            List<ChiTietPhieuNhapDTO> chiTiets = ChiTietPhieuNhapBLL.GetAll(phieuNhap.MaPN);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Thukho.rpt_Nhap.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("CTPN", chiTiets));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paTenNV", nhanVien));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paNgayTao", phieuNhap.NgayTaoPN.ToString()));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paMaPN", phieuNhap.MaPN));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paTenNCC", tenncc));
            reportViewerResult.RefreshReport();
        }
    }
}
