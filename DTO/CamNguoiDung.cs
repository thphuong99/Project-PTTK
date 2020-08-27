using System.Data;

namespace DTO
{
    public class CamNguoiDung
    {
        private int ID;
        public int _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        private string EMAIL;
        public string _EMAIL
        {
            get { return EMAIL; }
            set { EMAIL = value; }
        }

        public CamNguoiDung(string Email)
        {
            this._EMAIL = EMAIL;
        }
        public CamNguoiDung(DataRow row)
        {
            this._EMAIL = row["_EMAIL"].ToString();
        }
    }
}
