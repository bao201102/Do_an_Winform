using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    class SanPhamBLL
    {
        public static List<object> GetProduct()
        {
            return SanPhamDAL.GetProduct();
        }

        public static List<object> GetProductByName(string tensp)
        {
            return SanPhamDAL.GetProductByName(tensp);
        }
        
    }
}
