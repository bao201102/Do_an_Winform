using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform
{
    public partial class frm_ThuKho_main : Form
    {
        public frm_ThuKho_main()
        {
            InitializeComponent();
            this.Width = 1600;
            this.Height = 900;
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panelStorekeeperSub.Visible = false;
            panelSettingSub.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSettingSub.Visible == true)
                panelSettingSub.Visible = false;
            if (panelStorekeeperSub.Visible == true)
                panelStorekeeperSub.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();            
        }

        private void btnStoreKeeper_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStorekeeperSub);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Nhap());
        }
    }
}
