using Do_an_Winform.PL.DangNhap;
using Do_an_Winform.PL.Nhanvien;
using Do_an_Winform.PL.Quanly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
            Application.Run(new frm_HDNH());
=======
            Application.Run(new frm_DangNhap());
>>>>>>> Stashed changes
        }
    }
}
