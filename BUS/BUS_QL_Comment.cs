using DAL;
using System.Data;

namespace BUS
{
    public class BUS_QL_Comment
    {
        DAL_QL_Comment dal_ql_comment = new DAL_QL_Comment();
        public DataTable getComment_Xau()
        {
            return dal_ql_comment.QL_getComment_Xau();
        }
        public DataTable getComment_Tot()
        {
            return dal_ql_comment.QL_getComment_Tot();
        }

        public bool DeleteComment(string MABL)
        {
            return dal_ql_comment.DeleteComment(MABL);
        }

        public bool InsertNguoiDung_Cam(string EMAIL)
        {
            return dal_ql_comment.InsertNguoiDung_Cam(EMAIL);
        }
    }
}
