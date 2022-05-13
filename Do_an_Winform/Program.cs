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
            Application.Run(new frm_DangNhap());
=======
            Application.Run(new frm_Nhanvien());
>>>>>>> b6203a0f4745405e3ef2c85c5af87bed0adc4a30
        }
    }
}
