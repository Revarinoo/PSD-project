using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User us = (User)Session["User"];
            if(Session["user"] != null)
            {
                GenerateUserDetail(us);
            }else
            {
                Response.Redirect("Home.aspx");
            }
        }

        private void GenerateUserDetail(User us)
        {
            UserNameLabel.Text = us.Name;
            UserEmailLabel.Text = us.Email;
            UserGenderLabel.Text = us.Gender;
        }

        protected void BacktoHomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }
    }
}