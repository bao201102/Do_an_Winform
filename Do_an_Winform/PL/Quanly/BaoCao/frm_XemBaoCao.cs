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
            List<ChiTietPhieuNhapDTO> chiTiets = ChiTietPhieuNhapBLL.GetAllByID(phieuNhap.MaPN);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Thukho.rpt_Nhap.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("CTPN", chiTiets));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paTenNV", nhanVien));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paNgayTao", phieuNhap.NgayTaoPN.ToString()));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paMaPN", phieuNhap.MaPN));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paTenNCC", tenncc));
            reportViewerResult.RefreshReport();
        }
        public void rpt_HDBH_MaHD(string mahd, DateTime sDay, DateTime eDay)
        {
            HoaDonDTO hdsearch = new HoaDonDTO();
            hdsearch.MaHD = mahd;
            List<HoaDonDTO> listhd = HoaDonBLL.ThongKeTheoMaHD(hdsearch, sDay, eDay);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.BaoCao.rpt_HDBH.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("HoaDon_HDBH", listhd));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paMaHD", mahd));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paStartDay", sDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paEndDay", eDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.RefreshReport();
        }
        public void rpt_HDBH_TatCaHD(DateTime sDay, DateTime eDay)
        {
            List<HoaDonDTO> listhd = HoaDonBLL.ThongKeTatCaHD(sDay, eDay);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.BaoCao.rpt_HDBH.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("HoaDon_HDBH", listhd));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paMaHD", "Tất cả"));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paStartDay", sDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paEndDay", eDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.RefreshReport();
        }
        public void rpt_HDNH_MaPN(string mapn, DateTime sDay, DateTime eDay)
        {
            PhieuNhapHangDTO pnsearch = new PhieuNhapHangDTO();
            pnsearch.MaPN = mapn;
            List<PhieuNhapHangDTO> listpn = PhieuNhapHangBLL.ThongKeTheoMaPN(pnsearch, sDay, eDay);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.BaoCao.rpt_HDNH.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapHang_HDNH", listpn));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paMaPN", mapn));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paStartDay", sDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paEndDay", eDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.RefreshReport();
        }
        public void rpt_HDNH_TatCaPN(DateTime sDay, DateTime eDay)
        {
            List<PhieuNhapHangDTO> listpn = PhieuNhapHangBLL.ThongKeTatCaPN(sDay, eDay);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.BaoCao.rpt_HDNH.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapHang_HDNH", listpn));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paMaPN", "Tất cả"));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paStartDay", sDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paEndDay", eDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.RefreshReport();
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
