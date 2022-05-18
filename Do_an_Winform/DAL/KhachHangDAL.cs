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
                            join loaitv in entities.LoaiThanhViens
                            on kh.MaLoaiTVien equals loaitv.MaLoaiTVien
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
        public static List<KhachHangDTO> GetCusByTxtNameChanged(string txtNameChanged)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var customers = from kh in entities.KhachHangs
                            where kh.TenKH.Contains(txtNameChanged)
                            select kh;
            List<KhachHangDTO> khachHangDTOs = new List<KhachHangDTO>();
            foreach (KhachHang ctm in customers)
            {
                if (ctm.TrangThai == "1")
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
                    var mapper = new Mapper(config);
                    KhachHangDTO khachhang = mapper.Map<KhachHangDTO>(ctm);
                    khachHangDTOs.Add(khachhang);
                }
            }
            return khachHangDTOs;
        }
        public static bool AddNewCustomer(KhachHangDTO kh) 
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHangDTO, KhachHang>());
            var mapper = new Mapper(config);
            KhachHang khachHang = mapper.Map<KhachHang>(kh);
            CHDTEntities1 entities = new CHDTEntities1();
            entities.KhachHangs.Add(khachHang);
            return entities.SaveChanges() > 0 ? true : false;
        }
        public static KhachHangDTO GetCustomerWithName(string name)
        {
            CHDTEntities1 data = new CHDTEntities1();
            KhachHang khachhang = (from kh in data.KhachHangs
                                   where kh.TenKH == name.Trim().ToLower()
                                   select kh).SingleOrDefault();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
            var mapper = new Mapper(config);
            KhachHangDTO dto = mapper.Map<KhachHangDTO>(khachhang);
            return dto;
        }
        public static bool AddCustomer(KhachHangDTO dto)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHangDTO, KhachHang>());
            var mapper = new Mapper(config);
            KhachHang kh = mapper.Map<KhachHang>(dto);
            data.KhachHangs.Add(kh);
            return data.SaveChanges() > 0 ? true : false;
        }

    }
}
