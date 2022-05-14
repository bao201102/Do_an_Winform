using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    public class TaiKhoanBLL
    {
        public static TaiKhoanDTO GetUser(TaiKhoan account)
        {
            return TaiKhoanDAL.GetUser(account);
        }
    }
}
