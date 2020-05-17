using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User us = (User)Session["user"];
            if (Session["user"] != null)
            {
                btnLogin.Visible = false;
                if(us.RoleID == 1)
                {
                    btnCart.Visible = false;
                    btnHistory.Visible = false;
                }
            }
            else
            {
                btnLogout.Visible = false;
                btnProfile.Visible = false;
                btnCart.Visible = false;
                btnHistory.Visible = false;
            }
        }

        protected void homeLogin(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void homeLogout(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies["email"].Expires = DateTime.Now.AddHours(-2);
            Response.Cookies["pass"].Expires = DateTime.Now.AddHours(-2);
            Response.Redirect("Home.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }
    }
}