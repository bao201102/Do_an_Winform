using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    public class NhanVienBLL
    {
        public static NhanVienDTO GetEmployee(string manguoidung)
        {
            return NhanVienDAL.GetEmployee(manguoidung);
        }

        public static NhanVienDTO GetEmployeeById(string manv)
        {
            return NhanVienDAL.GetEmployeeById(manv);
        }

        public static List<object> GetEmployeeByName(string name)
        {
            return NhanVienDAL.GetEmployeeByName(name);
        }

        public static List<object> GetAllEmployee()
        {
            return NhanVienDAL.GetAllEmployee();
        }

        public static bool AddEmployee(NhanVienDTO nvDTO)
        {
            return NhanVienDAL.AddEmployee(nvDTO);
        }

        public static bool UpdateEmployee(NhanVienDTO empDTO)
        {
            return NhanVienDAL.UpdateEmployee(empDTO);
        }
        public static List<NhanVienDTO> LayTatCaNhanVien()
        {
            return NhanVienDAL.LayTatCaNhanVien();
        }
        public static int CountEmployee()
        {
            return NhanVienDAL.CountEmployee();
        }
    }
}
