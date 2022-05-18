using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class NhaSanXuatDAL
    {
        public static List<NhaSanXuatDTO> GetAllManufac()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var manufacs = from nhasx in entities.NhaSanXuats
                           join sp in entities.SanPhams
                           on nhasx.MaNhaSX equals sp.MaNhaSX
                           select nhasx;
            List<NhaSanXuatDTO> nhaSanXuatDTOs = new List<NhaSanXuatDTO>();
            nhaSanXuatDTOs.Add(new NhaSanXuatDTO("Tất cả", "Tất cả"));
            foreach (NhaSanXuat nsx in manufacs)
            {
                
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaSanXuat, NhaSanXuatDTO>());
                var mapper = new Mapper(config);
                NhaSanXuatDTO nhasx = mapper.Map<NhaSanXuatDTO>(nsx);
                nhaSanXuatDTOs.Add(nhasx);
                
            }
            return nhaSanXuatDTOs;
        }

        public static NhaSanXuatDTO GetManufacById(string maNhaSX)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            NhaSanXuat manufac = (from nhasx in entities.NhaSanXuats
                                   where nhasx.MaNhaSX == maNhaSX
                                   select nhasx).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaSanXuat, NhaSanXuatDTO>());
            var mapper = new Mapper(config);
            NhaSanXuatDTO nhaSX = mapper.Map<NhaSanXuatDTO>(manufac);
            return nhaSX;
        }
    }
}
