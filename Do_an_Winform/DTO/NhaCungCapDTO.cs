using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class NhaCungCapDTO
    {
        private string _MaNCC;
        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        private string _TenNCC;
        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }

        public NhaCungCapDTO()
        {
            this.MaNCC = "";
            this.TenNCC = "";
        }

        public NhaCungCapDTO(string MaNCC_, string TenNCC_)
        {
            this.MaNCC = MaNCC_;
            this.TenNCC = TenNCC_;
        }
    }
}
