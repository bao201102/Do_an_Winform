using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    class ChiTietPhieuNhapDAL
    {
        public static bool AddChiTietPN(ChiTietPhieuNhapDTO phieuNhapDTO)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            phieuNhapDTO.TrangThai = "1";

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietPhieuNhapDTO, ChiTietPhieuNhap>());
            var mapper = new Mapper(config);
            ChiTietPhieuNhap phieuNhap = mapper.Map<ChiTietPhieuNhap>(phieuNhapDTO);
            
            entities.ChiTietPhieuNhaps.Add(phieuNhap);
            return entities.SaveChanges() > 0 ? true : false;
        }

        public static List<ChiTietPhieuNhapDTO> GetAll(string maPn)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var query = from pn in entities.ChiTietPhieuNhaps
                           where pn.MaPN.Equals(maPn)
                           select pn;
            List<ChiTietPhieuNhapDTO> chiTiets = new List<ChiTietPhieuNhapDTO>();
            foreach (ChiTietPhieuNhap pro in query)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietPhieuNhap, ChiTietPhieuNhapDTO>());
                var mapper = new Mapper(config);
                ChiTietPhieuNhapDTO phieuNhapDTO = mapper.Map<ChiTietPhieuNhapDTO>(pro);
                chiTiets.Add(phieuNhapDTO);
            }
            return chiTiets;
        }
    }
}
