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
                             where us.TaiKhoan1 == account.TaiKhoan1 && us.MatKhau == account.MatKhau
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
        public static bool AddAccount(TaiKhoanDTO dto)
        {
            CHDTEntities1 entities = new CHDTEntities1();

            var query = (from x in entities.TaiKhoans
                         select x).Count();
            dto.MaNguoiDung = "US" + (query + 1).ToString("000");

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TaiKhoanDTO, TaiKhoan>());
            var mapper = new Mapper(config);
            TaiKhoan tk = mapper.Map<TaiKhoan>(dto);
            entities.TaiKhoans.Add(tk);
            try
            {
                entities.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
    }
}
