using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class ChiTietHoaDonDAL
    {
        public static bool AddNewBillDetail(ChiTietHoaDonDTO chitiethd)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietHoaDonDTO, ChiTietHoaDon>());
            var mapper = new Mapper(config);
            ChiTietHoaDon chiTietHD = mapper.Map<ChiTietHoaDon>(chitiethd);
            data.ChiTietHoaDons.Add(chiTietHD);
            return data.SaveChanges() > 0 ? true : false;
        }
    }
}
