using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BAL;
namespace Task_Otobit
{
    public partial class ShowMyDetails : System.Web.UI.Page
    {
        Bal bal = new Bal();
        Model model = new Model();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt = bal.BindUserIDName();
                //Buisness layer Code
                drpUserId.Items.Clear();
                drpUserId.DataSource = dt;
                drpUserId.DataTextField = "UserId";
                drpUserId.DataValueField = "UserName";
                drpUserId.DataBind();
                drpUserId.Items.Insert(0, "Select");
                drpUserId.SelectedIndex = 0;

            }
        }

        protected void drpUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int UserId = Convert.ToInt32(drpUserId.SelectedIndex);
            dt = bal.BindUserByID(UserId);

            txtUserName.Text = dt.Rows[0]["UserName"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();

            txtPassword.Text = dt.Rows[0]["Password"].ToString();
        }

        protected void btnShowMyProfile_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int UserId = Convert.ToInt32(drpUserId.SelectedIndex);
            dt = bal.BindUserByID(UserId);

            txtUserName.Text = dt.Rows[0]["UserName"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();

            txtPassword.Text = dt.Rows[0]["Password"].ToString();
        }
    }
}