using System;

namespace DTO
{
	public class TinNhanQC
    {
		private int _Id;

		public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

		private string _NoiDung;

		public string NoiDung
		{
			get { return _NoiDung; }
			set { _NoiDung = value; }
		}
		
		private int _NguoiGui;

		public int NguoiGui
		{
			get { return _NguoiGui; }
			set { _NguoiGui = value; }
		}

		private DateTime _NgayGui;

		public DateTime NgayGui
		{
			get { return _NgayGui; }
			set { _NgayGui = value; }
		}

		private int _NguoiNhan;

		public int NguoiNhan
		{
			get { return _NguoiNhan; }
			set { _NguoiNhan = value; }
		}

		public TinNhanQC(string pNoiDung, int pNguoiGui, DateTime pNgayGui, int pNguoiNhan)
		{
			this._NoiDung = pNoiDung;
			this._NguoiGui = pNguoiGui;
			this._NgayGui = pNgayGui;
			this._NguoiNhan = pNguoiNhan;
		}
	}
}
