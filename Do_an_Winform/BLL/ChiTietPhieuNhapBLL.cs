using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    class ChiTietPhieuNhapBLL
    {
        public static bool AddChiTietPN(ChiTietPhieuNhapDTO phieuNhapDTO)
        {
            return ChiTietPhieuNhapDAL.AddChiTietPN(phieuNhapDTO);
        }
        public static List<ChiTietPhieuNhapDTO> GetAll(string maPn)
        {
            return ChiTietPhieuNhapDAL.GetAll(maPn);
        }
    }
}
