using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODEL;

namespace BAL
{
    public class Bal
    {
        Dal dal = new Dal();

        public DataTable BindUserByID(int UserId)
        {
            return dal.BindUserID(UserId);

        }
        public DataTable BindUserIDName()
        {
            return dal.BindUserIDName();
        }
        public int SubmitUser(Model model)
        {
            return dal.SubmitUserDetails(model);
        }


        public int Update_Data(Model model)
        {
            return dal.Update_Email(model);
        }
    }
}
