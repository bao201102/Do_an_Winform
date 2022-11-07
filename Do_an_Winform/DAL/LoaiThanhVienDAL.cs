using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class LoaiThanhVienDAL
    {
        public static List<LoaiThanhVienDTO> GetAllTypeMem()
        {
            CHDTEntities entities = new CHDTEntities();
            var listloaitv = from loaitv in entities.LoaiThanhViens
                             select loaitv;
            List<LoaiThanhVienDTO> loaithanhviens = new List<LoaiThanhVienDTO>();
            foreach(LoaiThanhVien loaithanhvien in listloaitv)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiThanhVien, LoaiThanhVienDTO>());
                var mapper = new Mapper(config);
                LoaiThanhVienDTO loaitvien = mapper.Map<LoaiThanhVienDTO>(loaithanhvien);
                loaithanhviens.Add(loaitvien);
            }
            return loaithanhviens;
        }
        public static LoaiThanhVienDTO GetTypeMemById(string maloaitv)
        {
            CHDTEntities entities = new CHDTEntities();
            LoaiThanhVien loaitv = (from loaithanhvien in entities.LoaiThanhViens
                         where loaithanhvien.MaLoaiTVien == maloaitv
                         select loaithanhvien).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiThanhVien, LoaiThanhVienDTO>());
            var mapper = new Mapper(config);
            LoaiThanhVienDTO custmType = mapper.Map<LoaiThanhVienDTO>(loaitv);
            return custmType;
        }
    }
}
