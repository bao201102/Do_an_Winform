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

        private void GetSumRevenue(Dictionary<int, double> revenue)
        {
            double sum = 0;
            foreach (KeyValuePair<int,double> item in revenue)
            {
                sum += item.Value;
            }
            lblDT.Text = String.Format("{0:0,0}", sum);
        }

        private void chartDT_Load(Dictionary<int, double> data)
        {
            chartCanvasDT.Clear();
            barChartDT.Data.Clear();

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
            cbDate.SelectedIndex = 0;
            chartDT_Load(HoaDonBLL.GetRevenueByThisMonth(DateTime.Now));
            GetSumRevenue(HoaDonBLL.GetRevenueByThisMonth(DateTime.Now));
        }

        private void cbDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDate.SelectedIndex == 0)
            {
                chartDT_Load(HoaDonBLL.GetRevenueByThisMonth(DateTime.Now));
                GetSumRevenue(HoaDonBLL.GetRevenueByThisMonth(DateTime.Now));
            }
            else
            {
                chartDT_Load(HoaDonBLL.GetRevenueByThisYear(DateTime.Now));
                GetSumRevenue(HoaDonBLL.GetRevenueByThisYear(DateTime.Now));
            }
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbDate_SelectionChangeCommitted(sender, e);
        }
    }
}
