using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class PhieuNhapHangDTO
    {
		private string _MaPN;
		public string MaPN
		{
			get { return _MaPN; }
			set { _MaPN = value; }
		}

		private DateTime _NgayTaoPN;
		public DateTime NgayTaoPN
		{
			get { return _NgayTaoPN; }
			set { _NgayTaoPN = value; }
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

		public PhieuNhapHangDTO()
        {
			this.MaPN = "";
			this.NgayTaoPN = DateTime.MinValue;
			this.MaNV = "";
			this.MaNCC = "";
		}

		public PhieuNhapHangDTO(string MaPN_, DateTime NgayTaoPN_, string MaNV_, string MaNCC_)
		{
			this.MaPN = MaPN_;
			this.NgayTaoPN = NgayTaoPN_;
			this.MaNV = MaNV_;
			this.MaNCC = MaNCC_;
		}
	}
}
