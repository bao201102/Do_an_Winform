using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.DoiTac
{
    public partial class frm_BaoCaoDoiTac : Form
    {
        string thongtin;
        public frm_BaoCaoDoiTac(string info)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            thongtin = info;
        }

        private void frm_BaoCaoNV_Load(object sender, EventArgs e)
        {

            this.rptBaoCao.RefreshReport();
        }

        private void rptBaoCaoNV_Load(object sender, EventArgs e)
        {
            if (thongtin == "1")
            {
                List<NhanVienDTO> list = NhanVienBLL.LayTatCaNhanVien();
                this.rptBaoCao.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.DoiTac.ReportNV.rdlc";
                rptBaoCao.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list));
                this.rptBaoCao.RefreshReport();
            }
            else if (thongtin == "2")
            {
                List<KhachHangDTO> list = KhachHangBLL.LayTatCaKhachHang();
                this.rptBaoCao.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.DoiTac.ReportKH.rdlc";
                rptBaoCao.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list));
                this.rptBaoCao.RefreshReport();
            }
            else if (thongtin == "3")
            {
                List<NhaCungCapDTO> list = NhaCungCapBLL.GetNhaCungCap();
                this.rptBaoCao.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.DoiTac.ReportNCC.rdlc";
                rptBaoCao.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetNCC", list));
                this.rptBaoCao.RefreshReport();
            }
        }
    }
}
