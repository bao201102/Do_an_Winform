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
        public static List<NhaSanXuatDTO> GetManufacById(string manhasx)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var manufacs = from nhasx in entities.NhaSanXuats
                           join sp in entities.SanPhams
                           on nhasx.MaNhaSX equals sp.MaNhaSX
                           where nhasx.MaNhaSX == manhasx
                           select nhasx;
            List<NhaSanXuatDTO> nhaSanXuatDTOs = new List<NhaSanXuatDTO>();
            foreach (NhaSanXuat nsx in manufacs)
            {
                
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaSanXuat, NhaSanXuatDTO>());
                var mapper = new Mapper(config);
                NhaSanXuatDTO nhasx = mapper.Map<NhaSanXuatDTO>(nsx);
                nhaSanXuatDTOs.Add(nhasx);
                
            }
            return nhaSanXuatDTOs;
        }
    }
}
