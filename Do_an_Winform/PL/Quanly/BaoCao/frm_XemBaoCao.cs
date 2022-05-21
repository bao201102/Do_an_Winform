using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.BaoCao
{
    public partial class frm_XemBaoCao : Form
    {
        public frm_XemBaoCao()
        {
            InitializeComponent();
        }

        private void frm_XemBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewerResult.RefreshReport();
        }
    }
}
