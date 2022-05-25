using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class TaiKhoanDAL
    {
        public static TaiKhoanDTO GetUser(TaiKhoan account)
        {

            CHDTEntities1 entities = new CHDTEntities1();
            TaiKhoan user = (from us in entities.TaiKhoans
                             where us.UserName == account.UserName && us.MatKhau == account.MatKhau
                             select us).SingleOrDefault();

            if (user != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<TaiKhoan, TaiKhoanDTO>());
                var mapper = new Mapper(config);
                TaiKhoanDTO taikhoan = mapper.Map<TaiKhoanDTO>(user);
                return taikhoan;
            }
            else
            {
                return null;
            }
        }
    }
}
