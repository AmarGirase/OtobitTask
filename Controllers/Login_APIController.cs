using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL;

namespace Task_Otobit.Controllers
{
    public class Login_APIController : ApiController
    {
        Bal bal = new Bal();

        // //We can Get the for our table using this Url

        [HttpGet]
        public List<Model> FillUserMasterAPI(int UserId)
        {
            // http://localhost:53570/api/Login_API/FillUserMasterAPI?UserId=1
            DataTable dt = bal.BindUserByID(UserId);

            List<Model> lst = new List<Model>();


            foreach (DataRow rd in dt.Rows)
            {
                lst.Add(new Model()
                {
                    UserId = Convert.ToInt32(rd["UserId"]),
                    UserName = rd["UserName"].ToString(),
                    Email = rd["Email"].ToString(),
                    Password = rd["Password"].ToString()
                });
            }

            return lst;

        }

        ///Using PostMan we can access this url
        // http://localhost:53570/api/Login_API/Submit_User
        [HttpPost]
        public int Submit_User(Model model)
        {
            int res = bal.SubmitUser(model);

            return res;
        }


        //url = http://localhost:53570/api/Login_API/Update_Email
        [HttpPost]
        public int Update_Email(Model model)
        {
            int res = bal.Update_Data(model);

            return res;
        }
    }
}

