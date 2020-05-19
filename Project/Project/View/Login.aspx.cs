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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    if (Request.Cookies["email"] != null && Request.Cookies["pass"] != null)
                    {
                        TxtMail.Text = Request.Cookies["email"].Value;
                        TxtPass.Attributes["value"] = Request.Cookies["pass"].Value;
                    }
                }
            }
        }

        protected void DoLogin(object sender, EventArgs e)
        {
            String email = TxtMail.Text.ToString();
            String pass = TxtPass.Text.ToString();
            String errorMsg = "";
            User usr = AuthController.SearchByEmail(email);
            bool success = AuthController.doLogin(email, pass, out errorMsg);
            if(!success)
            {
                labelError.Visible = true;
                labelError.Text = errorMsg;
            }

            else
            {
                    if (!success)
                    {
                        labelError.Visible = true;
                        labelError.Text = errorMsg;
                    }
                    else
                    {
                        Session["user"] = usr;
                        if (rememberMe.Checked)
                        {
                            Response.Cookies["email"].Value = TxtMail.Text;
                            Response.Cookies["pass"].Value = TxtPass.Text;
                            Response.Cookies["email"].Expires = DateTime.Now.AddDays(7);
                            Response.Cookies["pass"].Expires = DateTime.Now.AddDays(7);
                        }
                        else
                        {
                            Response.Cookies["email"].Expires = DateTime.Now.AddDays(-7);
                            Response.Cookies["pass"].Expires = DateTime.Now.AddDays(-7);
                        }
                        Response.Redirect("Home.aspx");
                    }
            }
        }
    }
}