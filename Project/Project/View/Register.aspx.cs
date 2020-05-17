using Project.Controller;
using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class Register : System.Web.UI.Page
    {
        private static TokobediaEntities dbEntity = new TokobediaEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void DoRegister(object sender, EventArgs e)
        {
            string name = TxtName.Text.ToString();
            string email = TxtEmail.Text.ToString();
            string password = TxtPassword.Text.ToString();
            string gender = RadioButtonGender.Text.ToString();
            string conf = TxtConfirm.Text.ToString();
            string errorMsg = "";
            bool success = UserController.doRegister(name, email, password, gender, conf, out errorMsg);
            if(!success)
            {
                labelError.Visible = true;
                labelError.Text = errorMsg;
            }
            else
            {
                UserController.addUser(name, email, password, gender);
                Response.Redirect("Login.aspx");
            }
        }
    }
}