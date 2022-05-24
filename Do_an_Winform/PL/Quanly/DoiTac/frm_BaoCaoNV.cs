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
    public partial class frm_BaoCaoNV : Form
    {
        public frm_BaoCaoNV()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frm_BaoCaoNV_Load(object sender, EventArgs e)
        {

            this.rptBaoCaoNV.RefreshReport();
        }

        private void rptBaoCaoNV_Load(object sender, EventArgs e)
        {
            List<NhanVienDTO> list = NhanVienBLL.LayTatCaNhanVien();
            rptBaoCaoNV.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",list));
            this.rptBaoCaoNV.RefreshReport();

        }
    }
}
