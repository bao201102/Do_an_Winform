using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class PhieuXuatHangDTO
    {
		private string _MaPX;
		public string MaPX
		{
			get { return _MaPX; }
			set { _MaPX = value; }
		}

		private DateTime _NgayTaoPX;
		public DateTime NgayTaoPX
		{
			get { return _NgayTaoPX; }
			set { _NgayTaoPX = value; }
		}

		private string _MaNV;
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}

		private string _MaNCC;
		public string MaNCC
		{
			get { return _MaNCC; }
			set { _MaNCC = value; }
		}

		public PhieuXuatHangDTO()
        {
			this.MaPX = "";
			this.NgayTaoPX = DateTime.MinValue;
			this.MaNV = "";
			this.MaNCC = "";
		}

		public PhieuXuatHangDTO(string MaPX_, DateTime NgayTaoPX_, string MaNV_, string MaNCC_)
		{
			this.MaPX = MaPX_;
			this.NgayTaoPX = NgayTaoPX_;
			this.MaNV = MaNV_;
			this.MaNCC = MaNCC_;
		}
	}
}
