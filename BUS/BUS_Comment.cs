using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Comment    
    {
        DAL_Comment dal_comment = new DAL_Comment();
        public DataTable getSanPham()
        {
            return dal_comment.getSanPham();
        }

        public bool InsertComment(Comment binhluan)
        {
            return dal_comment.InsertComment(binhluan);
        }

        public DataTable getComment(string MASP)
        {
            return dal_comment.getComment(MASP);
        }

        public DataTable getNguoiDung_Cam()
        {
            return dal_comment.getNguoiDung_Cam();
        }
    }
}
