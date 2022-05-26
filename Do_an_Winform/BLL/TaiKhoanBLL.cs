using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    public class TaiKhoanBLL
    {
        public static TaiKhoanDTO GetUser(TaiKhoan account)
        {
            return TaiKhoanDAL.GetUser(account);
        }

        public static bool AddAccount(TaiKhoanDTO dto)
        {
            return TaiKhoanDAL.AddAccount(dto);
        }

        public static List<TaiKhoanDTO> GetMaLoaiNV(string maloai)
        {
            return TaiKhoanDAL.GetMaLoaiNV(maloai);
        }

        public static bool RemoveAccount(TaiKhoanDTO dto, string manguoidung)
        {
            return TaiKhoanDAL.RemoveAccount(dto,manguoidung);
        }

        public static string GetUserId(string username)
        {
            return TaiKhoanDAL.GetUserId(username);
        }

        public static bool UpdatePassword(TaiKhoanDTO dto)
        {
            return TaiKhoanDAL.UpdatePassword(dto);
        }
    }
}
