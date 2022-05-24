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
    public partial class frm_BaoCaoNCC : Form
    {
        public frm_BaoCaoNCC()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frm_BaoCaoKH_Load(object sender, EventArgs e)
        {

            this.rptBaoCaoNCC.RefreshReport();
        }

        private void rptBaoCaoKH_Load(object sender, EventArgs e)
        {
            List<NhaCungCapDTO> list = NhaCungCapBLL.GetNhaCungCap();
            rptBaoCaoNCC.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetNCC",list));
            this.rptBaoCaoNCC.RefreshReport();

        }
    }
}
