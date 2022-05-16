using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Do_an_Winform.DTO;

namespace Do_an_Winform.DAL
{
    public class HoaDonDAL
    {
        public static List<HoaDonDTO> ThongKeTatCaHD(DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                           join cthd in data.ChiTietHoaDons on hd.MaHD equals cthd.MaHD
                           join sp in data.SanPhams on cthd.MaSP equals sp.MaSP
                           where (hd.NgayTaoHD >= startday) && (hd.NgayTaoHD <= endday)
                           select hd;

            List<HoaDonDTO> listKQ = new List<HoaDonDTO>();
            for (int i = 0; i < truyvan.Count(); i++)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonDTO>());
                var mapper = new Mapper(config);
                HoaDonDTO dto = mapper.Map<HoaDonDTO>(i);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<HoaDonDTO> ThongKeTheoMaHD(HoaDonDTO hdsearch, DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                          join cthd in data.ChiTietHoaDons on hd.MaHD equals cthd.MaHD
                          join sp in data.SanPhams on cthd.MaSP equals sp.MaSP
                          where (hd.MaHD == hdsearch.MaHD) && (hd.NgayTaoHD >= startday) && (hd.NgayTaoHD <= endday)
                          select hd;

            List<HoaDonDTO> listKQ = new List<HoaDonDTO>();
            for (int i = 0; i < truyvan.Count(); i++)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonDTO>());
                var mapper = new Mapper(config);
                HoaDonDTO dto = mapper.Map<HoaDonDTO>(i);
                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}
