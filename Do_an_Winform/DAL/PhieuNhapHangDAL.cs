using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    class PhieuNhapHangDAL
    {
        public static List<PhieuNhapHangDTO> ThongKeTatCaPN(DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs                        
                          where (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday)
                          select new
                          {
                              pn.MaPN,
                              //NgayTaoPN = ((DateTime)pn.NgayTaopn).ToString("dd/MM/yyyy HH:mm"),              
                              pn.NgayTaoPN,
                              pn.MaNV,
                              pn.MaNCC,
                              pn.ThanhTien
                          };

            List<PhieuNhapHangDTO> listKQ = new List<PhieuNhapHangDTO>();
            for (int i = 0; i < truyvan.Count(); i++)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO pndto = mapper.Map<PhieuNhapHangDTO>(i);
                listKQ.Add(pndto);
            }
            return listKQ;
        }
        public static List<PhieuNhapHangDTO> ThongKeTheoMaPN(PhieuNhapHangDTO pnsearch, DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.MaPN == pnsearch.MaPN) && (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday)
                          select new
                          {
                              pn.MaPN,
                              //NgayTaopn = ((DateTime)pn.NgayTaopn).ToString("dd/MM/yyyy HH:mm"),              
                              pn.NgayTaoPN,
                              pn.MaNV,
                              pn.MaNCC,
                              pn.ThanhTien
                          };
            List<PhieuNhapHangDTO> listKQ = new List<PhieuNhapHangDTO>();
            for (int i = 0; i < truyvan.Count(); i++)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO pndto = mapper.Map<PhieuNhapHangDTO>(i);
                listKQ.Add(pndto);
            }
            return listKQ;
        }
    }
}
