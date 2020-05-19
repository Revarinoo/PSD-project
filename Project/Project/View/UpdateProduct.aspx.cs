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
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TokobediaEntities dbEntity = new TokobediaEntities();
            User us = (User)Session["user"];
            if (Session["user"] != null)
            {
                if (us.RoleID == 1)
                {
                    GridViewUpdateP.DataSource = ViewProductController.getAllProduct();
                    GridViewUpdateP.DataBind();
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void UpdateP_Click(object send, EventArgs e)
        {
            int ProductID = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("UpdateProducts.aspx?ProductID=" + ProductID);
        }
    }
}