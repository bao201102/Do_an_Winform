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
    public partial class frm_BaoCaoKH : Form
    {
        public frm_BaoCaoKH()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frm_BaoCaoKH_Load(object sender, EventArgs e)
        {

            this.rptBaoCaoKH.RefreshReport();
        }

        private void rptBaoCaoKH_Load(object sender, EventArgs e)
        {
            List<KhachHangDTO> list = KhachHangBLL.LayTatCaKhachHang();
            rptBaoCaoKH.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",list));
            this.rptBaoCaoKH.RefreshReport();

        }
    }
}
