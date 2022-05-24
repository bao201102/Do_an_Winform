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
                       where cc.TrangThai == "1"
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

        public static bool AddNCC(NhaCungCapDTO dto)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCapDTO, NhaCungCap>());
            var mapper = new Mapper(config);
            NhaCungCap ncc = mapper.Map<NhaCungCap>(dto);
            data.NhaCungCaps.Add(ncc);
            return data.SaveChanges() > 0 ? true : false;
        }

        public static List<object> GetAllSupplierByName(string name)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            List<object> list = new List<object>();

            var query = from ncc in entities.NhaCungCaps
                        where ncc.TenNCC.Equals(name) && ncc.TrangThai == "1"
                        select new
                        {
                            ncc.MaNCC,
                            ncc.TenNCC,
                            ncc.SDT,
                            ncc.Email,
                            ncc.DiaChi
                        };

            foreach (var item in query)
            {
                list.Add(item);
            }
            return list;
        }

        public static List<object> GetAllSupplier()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            List<object> list = new List<object>();

            var query = from ncc in entities.NhaCungCaps
                        where ncc.TrangThai == "1"
                        select new
                        {
                            ncc.MaNCC,
                            ncc.TenNCC,
                            ncc.SDT,
                            ncc.Email,
                            ncc.DiaChi
                        };

            foreach (var item in query)
            {
                list.Add(item);
            }
            return list;
        }
        public static NhaCungCapDTO GetNhaCungCapByID(string mancc)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            NhaCungCap ncc = (from cc in entities.NhaCungCaps
                       where cc.TrangThai == "1" && cc.MaNCC.Equals(mancc)
                       select cc).FirstOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCap, NhaCungCapDTO>());
            var mapper = new Mapper(config);
            NhaCungCapDTO nhaCungCap = mapper.Map<NhaCungCapDTO>(ncc);

            return nhaCungCap;

        }
    }
}
