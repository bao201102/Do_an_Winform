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
        public static List<object> GetAllCustomer()
        {
            return KhachHangDAL.GetAllCustomer();
        }
        public static List<KhachHangDTO> GetCusByTxtNameChanged(string txtNameChanged)
        {
            return KhachHangDAL.GetCusByTxtNameChanged(txtNameChanged);
        }
        public static bool AddNewCustomer(KhachHangDTO kh)
        {
            return KhachHangDAL.AddNewCustomer(kh);
        }
        public static List<object> GetCustomerByName(string name)
        {
            return KhachHangDAL.GetCustomerByName(name);
        }
        public static bool AddCustomer(KhachHangDTO dto)
        {
            return KhachHangDAL.AddCustomer(dto);
        }
        
        public static KhachHangDTO GetCustomerByPhone(string phone)
        {
            return KhachHangDAL.GetCustomerByPhone(phone);
        }

    }
}
