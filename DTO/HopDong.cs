using System;

namespace DTO
{
	public class HopDong
    {
		private int _MaHopDong;

		public int MaHopDong
		{
			get { return _MaHopDong; }
			set { _MaHopDong = value; }
		}


		private string _TenDoiTac;

		public string TenDoiTac
		{
			get { return _TenDoiTac; }
			set { _TenDoiTac = value; }
		}

		private DateTime _NgayLap;

		public DateTime NgayLap
		{
			get { return _NgayLap; }
			set { _NgayLap = value; }
		}

		private string _ViTriDang;

		public string ViTriDang
		{
			get { return _ViTriDang; }
			set { _ViTriDang = value; }
		}

		private int _ThoiHan;

		public int ThoiHan
		{
			get { return _ThoiHan; }
			set { _ThoiHan = value; }
		}


		public HopDong(string pTenDoiTac, DateTime pNgayLap, string pViTriDang, int pThoiHan)
		{
			this._TenDoiTac = pTenDoiTac;
			this._NgayLap = pNgayLap;
			this._ViTriDang = pViTriDang;
			this._ThoiHan = pThoiHan;
		}

	}
}
