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
                        GridViewUser.DataSource = ViewUserController.getUser();
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

        protected void BacktoHomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void ChangeStatusButton_Click(object send, EventArgs e)
        {
            int id = Int32.Parse((send as LinkButton).CommandArgument);
            ChangeStatusController.ChangeStatus(id);
            Response.Redirect("ViewUser.aspx");
        }
    }
}