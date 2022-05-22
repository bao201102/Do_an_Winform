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

namespace Do_an_Winform.PL.Nhanvien
{
    public partial class frm_XemHoaDon : Form
    {
        string maHD = "";
        string tenNV = "";
        string ngayTao = "";
        string tenKH = "";
        string loaiTV = "";
        public frm_XemHoaDon(string maHD1, string tenNV1, string ngayTao1, string tenKH1, string loaiTV1)
        {
            InitializeComponent();
            maHD = maHD1;
            tenNV = tenNV1;
            ngayTao = ngayTao1;
            tenKH = tenKH1;
            loaiTV = loaiTV1;
        }

        private void frm_XemHoaDon_Load(object sender, EventArgs e)
        {

            this.rptHoaDon.RefreshReport();
        }

        private void rptHoaDon_Load(object sender, EventArgs e)
        {
            List<ChiTietHoaDonDTO> listCTHD = new List<ChiTietHoaDonDTO>();
            listCTHD = ChiTietHoaDonBLL.GetAllDetailBillById(maHD);
            rptHoaDon.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Nhanvien.rpt_HoaDon.rdlc";
            rptHoaDon.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CTHD", listCTHD));
            rptHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TenNV", tenNV));
            rptHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NgayTao", ngayTao));
            rptHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TenKH", tenKH));
            rptHoaDon.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("LoaiThanhVien", loaiTV));
        }
    }
}
