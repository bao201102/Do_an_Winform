using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    public class KhachHangBLL
    {
        public static List<KhachHangDTO> GetAllCustomer()
        {
            return KhachHangDAL.GetAllCustomer();
        }
        public static List<KhachHangDTO> GetCusByTxtNameChanged(string txtNameChanged)
        {
            return KhachHangDAL.GetCusByTxtNameChanged(txtNameChanged);
        }
    }
}
