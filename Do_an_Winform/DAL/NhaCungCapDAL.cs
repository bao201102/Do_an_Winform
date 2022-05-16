using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    class NhaCungCapDAL
    {
        public static List<NhaCungCapDTO> GetNhaCungCap()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var ncc = (from cc in entities.NhaCungCaps
                        select cc);

            List<NhaCungCapDTO> nhaCungCapDTOs = new List<NhaCungCapDTO>();
            foreach (NhaCungCap item in ncc)
            {
                
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCap, NhaCungCapDTO>());
                    var mapper = new Mapper(config);
                    NhaCungCapDTO nhaCungCap = mapper.Map<NhaCungCapDTO>(item);
                    nhaCungCapDTOs.Add(nhaCungCap);
                
            }
            return nhaCungCapDTOs;

        }
    }
}
