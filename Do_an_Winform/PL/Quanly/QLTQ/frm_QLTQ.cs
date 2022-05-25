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

namespace Do_an_Winform.PL.Quanly.QLTQ
{
    public partial class frm_QLTQ : Form
    {
        public frm_QLTQ()
        {
            InitializeComponent();
        }

        private void chartDT_Load(Dictionary<int, double> data)
        {
            //chartCanvasDT.Clear();
            //barChartDT.Data.Clear();

            List<string> x_AxisLabels = new List<string>();
            List<double> y_AxisLabels = new List<double>();

            foreach (var item in data)
            {
                string name = "" + item.Key;
                
                x_AxisLabels.Add(name);
                y_AxisLabels.Add(item.Value);
            }

            chartCanvasDT.Labels = x_AxisLabels.ToArray();
            barChartDT.Data = y_AxisLabels;

            chartCanvasDT.Update();
            chartCanvasDT.Refresh();
        }

        private void frm_QLTQ_Load(object sender, EventArgs e)
        {
            bunifuDatePicker1.Value = DateTime.Now;
            chartDT_Load(HoaDonBLL.GetRevenueByMonth(bunifuDatePicker1.Value));
        }
    }
}
