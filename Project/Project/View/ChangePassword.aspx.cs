using Project.Controller;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        //private User us;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                labelError.Visible = false;
                User us = (User)Session["user"];
                if(Session["user"] == null)
                {

                    Response.Redirect("Home.aspx");
                }
            }
        }

        protected void changepassBtn_Click(object sender, EventArgs e)
        {
            User us = (User)Session["user"];
            string oldpass = OldPassTextBox.Text.ToString();
            string newpass = NewPassTextBox.Text.ToString();
            string confpass = ConfirmPassTextBox.Text.ToString();

            string errorMsg = "";
            bool success = ChangePasswordController.validatePassword(us.UserID, oldpass, newpass, confpass, out errorMsg);
            if (!success)
            {
                labelError.Visible = true;
                labelError.Text = errorMsg;
            }
            else
            {
                Response.Redirect("ViewProfile.aspx");
            }
        }

        protected void backtohomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}