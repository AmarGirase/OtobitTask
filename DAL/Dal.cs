using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAL
{
    public class Dal
    {
        ///// Bind_EmpName For Get the EmpName Using ID

        public DataTable BindUserIDName()
        {
            string StrCon = @"data source=LAPTOP-QPOAGC3K;initial catalog=Otobit_Task;integrated security=true";
            SqlConnection Con = new SqlConnection(StrCon);
            SqlCommand cmd = new SqlCommand("SP_GetUserIDName", Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        /////Bind_UserID for Get the profile Details

        public DataTable BindUserID(int UserId)
        {
            string StrCon = @"data source=LAPTOP-QPOAGC3K;initial catalog=Otobit_Task;integrated security=true";
            SqlConnection Con = new SqlConnection(StrCon);
            SqlCommand cmd = new SqlCommand("SP_Get_ProfileData", Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("@UserID", DbType.Int32).Value = UserID;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;


        }

        ////////User can Save the Data

        public int SubmitUserDetails(Model model)
        {
            int res = 0;
            try
            {

                String str = @"data source=LAPTOP-QPOAGC3K;initial catalog=Otobit_Task;integrated security=true";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("Submit_All_Details", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", model.UserName);
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@Password", model.Password);


                cmd.ExecuteNonQuery();
                res = 1;
            }

            catch (Exception ex)
            {
                res = 0;
            }
            return res;
        }

        //////Update the Email data

        public int Update_Email(Model model)
        {
            int res = 0;
            try
            {
                String str = @"data source=LAPTOP-QPOAGC3K;initial catalog=Otobit_Task;integrated security=true";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("Update_Email", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", model.UserId);
                cmd.Parameters.AddWithValue("@Email", model.Email);


                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch (Exception ex)
            {
                res = 0;
            }
            return res;
        }
    }
}

