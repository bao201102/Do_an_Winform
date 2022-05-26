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

        private void chartCat_Load(Dictionary<string, double> data)
        {
            chartCanvasCat.Clear();
            horizontalBarChartCat.Data.Clear();

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

            chartCanvasCat.Labels = y_AxisLabels.ToArray();
            horizontalBarChartCat.Data = horizontalBarData;

            chartCanvasCat.Update();
            chartCanvasCat.Refresh();
        }

        private void chartProduct_Load(Dictionary<string, double> data)
        {
            chartCanvasProduct.Clear();
            horizontalBarChartProduct.Data.Clear();

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

            chartCanvasProduct.Labels = y_AxisLabels.ToArray();
            horizontalBarChartProduct.Data = horizontalBarData;

            chartCanvasProduct.Update();
            chartCanvasProduct.Refresh();
        }

        private void frm_QLBC_Load(object sender, EventArgs e)
        {
            bunifuDatePicker1.Value = DateTime.Now;
            cbDate.SelectedIndex = 0;
            chartProduct_Load(SanPhamBLL.GetTopProductByDay(bunifuDatePicker1.Value));
            chartCat_Load(LoaiSanPhamBLL.GetTopProductCatByDay(bunifuDatePicker1.Value));
        }

        private void cbLoaisp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDate.SelectedIndex == 0)
            {           
                chartProduct_Load(SanPhamBLL.GetTopProductByDay(bunifuDatePicker1.Value));
                chartCat_Load(LoaiSanPhamBLL.GetTopProductCatByDay(bunifuDatePicker1.Value));
            }
            else if (cbDate.SelectedIndex == 1)
            {
                chartProduct_Load(SanPhamBLL.GetTopProductByMonth(bunifuDatePicker1.Value));
                chartCat_Load(LoaiSanPhamBLL.GetTopProductCatByMonth(bunifuDatePicker1.Value));
            }
            else
            {
                chartProduct_Load(SanPhamBLL.GetTopProductByYear(bunifuDatePicker1.Value));
                chartCat_Load(LoaiSanPhamBLL.GetTopProductCatByYear(bunifuDatePicker1.Value));
            }
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbLoaisp_SelectionChangeCommitted(sender, e);
        }
    }
}
