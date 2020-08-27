using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_BHPL_Comment
    {
        DAL_BHPL_Comment dal_bhpl_comment = new DAL_BHPL_Comment();
        public DataTable BH_getComment()
        {
            return dal_bhpl_comment.BH_getComment();
        }
        public bool BH_updatecomment(Comment binhluan,string MABL)
        {
            return dal_bhpl_comment.BH_Updatecomment(binhluan,MABL);
        }
    }
}
