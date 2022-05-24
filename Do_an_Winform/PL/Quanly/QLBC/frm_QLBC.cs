using Do_an_Winform.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.QLBC
{
    public partial class frm_QLBC : Form
    {
        public frm_QLBC()
        {
            InitializeComponent();
        }

        private void frm_QLBC_Load(object sender, EventArgs e)
        {
            List<string> y_AxisLabels = new List<string>();
            List<double> horizontalBarData = new List<double>();

            foreach (var productData in SanPhamBLL.GetTopProduct(bunifuDatePicker1.Value).OrderByDescending(x => x.Value))
            {
                y_AxisLabels.Add(productData.Key);
                horizontalBarData.Add(productData.Value);
            }

            bunifuChartCanvas1.Labels = y_AxisLabels.ToArray();
            bunifuHorizontalBarChart1.Data = horizontalBarData;
        }
    }
}
