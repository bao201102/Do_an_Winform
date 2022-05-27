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
        public static List<NhaCungCapDTO> GetAllSupplier()
        {
            return NhaCungCapDAL.GetAllSupplier();
        }

        public static bool InsertSupplier(NhaCungCapDTO dto)
        {
            return NhaCungCapDAL.InsertSupplier(dto);
        }

        public static List<NhaCungCapDTO> GetAllSupplierByName(string name)
        {
            return NhaCungCapDAL.GetAllSupplierByName(name);
        }

        public static NhaCungCapDTO GetNhaCungCapByID(string mancc)
        {
            return NhaCungCapDAL.GetNhaCungCapByID(mancc);
        }
    }
}
