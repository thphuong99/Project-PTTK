using System;

namespace DTO
{
	public class TinQC
    {
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		private string _NoiDung;

		public string NoiDung
		{
			get { return _NoiDung; }
			set { _NoiDung = value; }
		}

		private int _NguoiDang;

		public int NguoiDang
		{
			get { return _NguoiDang; }
			set { _NguoiDang = value; }
		}

		private DateTime _NgayDang;

		public DateTime NgayDang
		{
			get { return _NgayDang; }
			set { _NgayDang = value; }
		}

		private DateTime _NgaySua;

		public DateTime NgaySua
		{
			get { return _NgaySua; }
			set { _NgaySua = value; }
		}

		private string _MaHopDong;

		public string MaHopDong
		{
			get { return _MaHopDong; }
			set { _MaHopDong = value; }
		}

		public TinQC(string pNoiDung, int pNguoiDang, DateTime pNgayDang, string pMaHopDong)
		{
			this._NoiDung = pNoiDung;
			this._NguoiDang = pNguoiDang;
			this._NgayDang = pNgayDang;
			this._MaHopDong = pMaHopDong;

		}

		public TinQC(int pId,string pNoiDung, DateTime pNgaySua)
		{
			this._ID = pId;
			this._NoiDung = pNoiDung;
			this._NgaySua = pNgaySua;

		}

		public TinQC(int pId)
		{
			this._ID = pId;
		}

		public TinQC(string pNoiDung, int pNguoiDang, DateTime pNgayDang, DateTime pNgaySua, string pMaHopDong)
		{
			this._NoiDung = pNoiDung;
			this._NguoiDang = pNguoiDang;
			this._NgayDang = pNgayDang;
			this._NgaySua = pNgaySua;
			this._MaHopDong = pMaHopDong;
		}

	}
}
