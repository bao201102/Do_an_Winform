using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class NhanVienDAL
    {
        public static NhanVienDTO GetEmployee(string manguoidung)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            NhanVien emp = (from nv in entities.NhanViens
                            where nv.MaNguoiDung == manguoidung
                            select nv).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
            var mapper = new Mapper(config);
            NhanVienDTO nhanVien = mapper.Map<NhanVienDTO>(emp);
            return nhanVien;
        }
    }
    
}
