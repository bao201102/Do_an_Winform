using Do_an_Winform.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly
{
    public partial class frm_TKDT : Form
    {
        public frm_TKDT()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            printPreviewDialogTKDT.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog printdialog = new PrintDialog();
            printdialog.AllowSomePages = true;
            printdialog.ShowHelp = true;
            printdialog.Document = printDocumentTKDT;
            DialogResult result = printdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocumentTKDT.Print();
            }
        }

        private void frm_TKDT_Load(object sender, EventArgs e)
        {
            maskedtxtToday.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");

            //Dữ liệu thống kê tháng hiện tại
            DateTime today = DateTime.ParseExact(maskedtxtToday.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            cbHTTK.SelectedItem = "Năm";
            txtNamTK.Text = DateTime.Now.ToString("yyyy");
            cbQuyTK.SelectedItem = LayQuy(today).ToString();
            cbThangTK.SelectedItem = today.Month;
            txtDoanhThu.Text = HoaDonDAL.ThongKeDoanhThuTheoTDHT(today).ToString();
        }
        private void cbQuyTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbThangTK.Items.Clear();
            object[] month1quarter = new object[] { 1, 2, 3, "Tất cả" };
            object[] month2quarter = new object[] { 4, 5, 6, "Tất cả" };
            object[] month3quarter = new object[] { 7, 8, 9, "Tất cả" };
            object[] month4quarter = new object[] { 10, 11, 12, "Tất cả" };
            if (cbQuyTK.SelectedItem == "1")
            {
                cbThangTK.Items.AddRange(month1quarter);
            }
            if (cbQuyTK.SelectedItem == "2")
            {
                cbThangTK.Items.AddRange(month2quarter);
            }
            if (cbQuyTK.SelectedItem == "3")
            {
                cbThangTK.Items.AddRange(month3quarter);
            }
            if (cbQuyTK.SelectedItem == "4")
            {
                cbThangTK.Items.AddRange(month4quarter);
            }
        }
        public int LayQuy(DateTime today)
        {
            if (today.Month == 1 || today.Month == 2 || today.Month == 3) return 1;
            else if (today.Month == 4 || today.Month == 5 || today.Month == 6) return 2;
            else if (today.Month == 7 || today.Month == 8 || today.Month == 9) return 3;
            else if (today.Month == 10 || today.Month == 11 || today.Month == 12) return 4;
            return 0;
        }
    }
}
