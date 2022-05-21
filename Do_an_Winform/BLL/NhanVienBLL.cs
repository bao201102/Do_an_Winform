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

        public static List<NhanVienDTO> GetEmployeeWithName(string name)
        {
            return NhanVienDAL.GetEmployeeWithName(name);
        }

        public static List<NhanVienDTO> GetAllEmployee()
        {
            return NhanVienDAL.GetAllEmployee();
        }

        public static bool AddEmployee(NhanVienDTO dto)
        {
            return NhanVienDAL.AddEmployee(dto);
        }

        public static bool UpdateEmployee(NhanVienDTO empDTO)
        {
            return NhanVienDAL.UpdateEmployee(empDTO);
        }
    }
}
