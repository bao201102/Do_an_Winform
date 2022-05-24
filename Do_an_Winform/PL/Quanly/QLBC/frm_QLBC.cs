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
        
        private void chart_Load(Dictionary<string, double> data)
        {
            bunifuChartCanvas1.Clear();
            bunifuHorizontalBarChart1.Data.Clear();

            List<string> y_AxisLabels = new List<string>();
            List<double> horizontalBarData = new List<double>();

            foreach (var productData in data.OrderByDescending(x => x.Value))
            {
                if (productData.Value > 0)
                {
                    y_AxisLabels.Add(productData.Key);
                    horizontalBarData.Add(productData.Value);
                }            
            }

            bunifuChartCanvas1.Labels = y_AxisLabels.ToArray();
            bunifuHorizontalBarChart1.Data = horizontalBarData;

            bunifuChartCanvas1.Update();
            bunifuChartCanvas1.Refresh();
        }

        private void frm_QLBC_Load(object sender, EventArgs e)
        {
            cbDate.SelectedIndex = 0;
            chart_Load(SanPhamBLL.GetTopProductByYear(bunifuDatePicker1.Value));
        }

        private void cbLoaisp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDate.SelectedIndex == 0)
            {           
                chart_Load(SanPhamBLL.GetTopProductByDay(bunifuDatePicker1.Value));
            }
            else if (cbDate.SelectedIndex == 1)
            {
                chart_Load(SanPhamBLL.GetTopProductByMonth(bunifuDatePicker1.Value));
            }
            else
            {
                chart_Load(SanPhamBLL.GetTopProductByYear(bunifuDatePicker1.Value));
            }
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbLoaisp_SelectionChangeCommitted(sender, e);
        }
    }
}
