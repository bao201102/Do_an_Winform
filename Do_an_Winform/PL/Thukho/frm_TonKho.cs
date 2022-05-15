using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Thukho
{
    public partial class frm_TonKho : Form
    {
        public frm_TonKho()
        {
            InitializeComponent();
        }

        private void frm_TonKho_Load(object sender, EventArgs e)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            entities.SanPhams.Load();
            gridviewStock.DataSource = entities.SanPhams.Local.ToBindingList();
        }
    }
}
