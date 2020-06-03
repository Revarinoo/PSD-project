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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        private User us;
        protected void Page_Load(object sender, EventArgs e)
        {
            us = (User)Session["user"];
            if(Session["user"] != null)
            {
                if (!IsPostBack)
                {
                    EmailUpdateTextBox.Text = us.Email;
                    UserNameUpdateTextBox.Text = us.Name;
                    RadioButtonGender.Text = us.Gender;
                }
            }else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void backtohomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int userID = us.UserID;
            string name = UserNameUpdateTextBox.Text.ToString();
            string email = EmailUpdateTextBox.Text.ToString();
            string gender = RadioButtonGender.Text.ToString();

            string errorMsg = "";
            labelError.Visible = true;
            bool success = UpdateProfileController.validateUpdate(userID, name, email, gender, out errorMsg);
            if (success)
            {
                Response.Redirect("Profile.aspx");
            }else
            {
                labelError.Text = errorMsg;
            }
        }
    }
}