using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class KhachHangDAL
    { 
        public static List<KhachHangDTO> GetAllCustomer()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var customers = from kh in entities.KhachHangs
                            select kh;
            List<KhachHangDTO> khachHangDTOs = new List<KhachHangDTO>();
            foreach(KhachHang ctm in customers)
            {
                if(ctm.TrangThai == "1")
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
                    var mapper = new Mapper(config);
                    KhachHangDTO khachhang = mapper.Map<KhachHangDTO>(ctm);
                    khachHangDTOs.Add(khachhang);
                }
            }
            return khachHangDTOs;
        }
    }
}
