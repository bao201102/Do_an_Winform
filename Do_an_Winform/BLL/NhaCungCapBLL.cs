using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    class NhaCungCapBLL
    {
        public static List<NhaCungCapDTO> GetNhaCungCap()
        {
            return NhaCungCapDAL.GetNhaCungCap();
        }

        public static bool AddNCC(NhaCungCapDTO dto)
        {
            return NhaCungCapDAL.AddNCC(dto);
        }

        public static List<object> GetAllSupplierByName(string name)
        {
            return NhaCungCapDAL.GetAllSupplierByName(name);
        }

        public static NhaCungCapDTO GetNhaCungCapByID(string mancc)
        {
            return NhaCungCapDAL.GetNhaCungCapByID(mancc);
        }
    }
}
