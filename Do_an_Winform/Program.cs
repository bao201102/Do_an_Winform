using Do_an_Winform.PL.DangNhap;
using Do_an_Winform.PL.Loading;
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
<<<<<<< HEAD
            Application.Run(new frm_Loading());
=======

            Application.Run(new frm_DangNhap());
>>>>>>> 159039179d0f5ba3b14dca6d235e218d8f440cf3
        }
    }
}
