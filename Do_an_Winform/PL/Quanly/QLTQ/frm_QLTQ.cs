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

        private void frm_QLTQ_Load(object sender, EventArgs e)
        {
            chartCanvasDT.Clear();
            barChartDT.Data.Clear();
        }
    }
}
