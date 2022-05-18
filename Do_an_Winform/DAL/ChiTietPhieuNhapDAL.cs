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
        public static bool Add(ChiTietPhieuNhapDTO phieuNhapDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietPhieuNhapDTO, ChiTietPhieuNhap>());
            var mapper = new Mapper(config);
            ChiTietPhieuNhap phieuNhap = mapper.Map<ChiTietPhieuNhap>(phieuNhapDTO);

            CHDTEntities1 entities = new CHDTEntities1();
            entities.ChiTietPhieuNhaps.Add(phieuNhap);
            return entities.SaveChanges() > 0 ? true : false;
        }
    }
}
