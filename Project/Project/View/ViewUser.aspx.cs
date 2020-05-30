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
    public partial class ViewUser : System.Web.UI.Page
    {
        TokobediaEntities dbEntity = new TokobediaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User us = (User)Session["user"];
                if(Session["user"] != null)
                {
                    if(us.RoleID == 1)
                    {
                        var item =
                        GridViewUser.DataSource = UserController.getAllUser();
                        GridViewUser.DataBind();
                    }else
                    {
                        Response.Redirect("Home.aspx");
                    }
                }else
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }
    }
}