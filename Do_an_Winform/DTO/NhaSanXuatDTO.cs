using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    public class NhaSanXuatDTO
    {
        private string _MaNhaSX;
        public string MaNhaSX
        {
            get { return _MaNhaSX; }
            set { _MaNhaSX = value; }
        }

        private string _TenNhaSX;
        public string TenNhaSX
        {
            get { return _TenNhaSX; }
            set { _TenNhaSX = value; }
        }

        public NhaSanXuatDTO()
        {
            this.MaNhaSX = "";
            this.TenNhaSX = "";
        }

        public NhaSanXuatDTO(string MaNhaSX_, string TenNhaSX_)
        {
            this.MaNhaSX = MaNhaSX_;
            this.TenNhaSX = TenNhaSX_;
        }

    }
}
