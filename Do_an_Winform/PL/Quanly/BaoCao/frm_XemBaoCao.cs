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
            this.FormBorderStyle = FormBorderStyle.None;
            this.reportViewerResult.RefreshReport();
        }

        public void rpt_Nhap(PhieuNhapHangDTO phieuNhap, string tenncc,string nhanVien)
        {
            lblBaocao.Text = "In phiếu nhập";
            List<ChiTietPhieuNhapDTO> chiTiets = ChiTietPhieuNhapBLL.GetAllByID(phieuNhap.MaPN);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Thukho.rpt_Nhap.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("CTPN", chiTiets));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paTenNV", nhanVien));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paNgayTao", phieuNhap.NgayTaoPN.ToString()));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paMaPN", phieuNhap.MaPN));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paTenNCC", tenncc));
            reportViewerResult.RefreshReport();
        }

        //Report HDBH
        public void rpt_HDBH_TatCaHD(DateTime sDay, DateTime eDay)
        {
            lblBaocao.Text = "Báo cáo hóa đơn bán hàng";
            List<HoaDonDTO> listhd = HoaDonBLL.ThongKeTatCaHD(sDay, eDay);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.BaoCao.rpt_HDBH.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("HoaDon_HDBH", listhd));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paStartDay", sDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.LocalReport.SetParameters(new ReportParameter("paEndDay", eDay.ToString("dd/MM/yyyy HH:mm")));
            reportViewerResult.RefreshReport();
        }

        //Report HDNH
        public void rpt_HDNH_TatCaPN(DateTime sDay, DateTime eDay)
        {
            lblBaocao.Text = "Báo cáo hóa đơn nhập hàng";
            List<PhieuNhapHangDTO> listpn = PhieuNhapHangBLL.ThongKeTatCaPN(sDay, eDay);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.BaoCao.rpt_HDNH.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new ReportDataSource("PhieuNhapHang_HDNH", listpn));
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

        public void rptHoaDon(string maHD, string tenNV, string ngayTao, string tenKH, string loaiTV, string giamGia)
        {
            List<ChiTietHoaDonDTO> listCTHD = new List<ChiTietHoaDonDTO>();
            listCTHD = ChiTietHoaDonBLL.GetAllDetailBillById(maHD);
            reportViewerResult.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Nhanvien.rpt_HoaDon.rdlc";
            reportViewerResult.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CTHD", listCTHD));
            reportViewerResult.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TenNV", tenNV));
            reportViewerResult.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NgayTao", ngayTao));
            reportViewerResult.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TenKH", tenKH));
            reportViewerResult.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("LoaiThanhVien", loaiTV));
            reportViewerResult.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("GiamGia", giamGia));
        }
    }
}
