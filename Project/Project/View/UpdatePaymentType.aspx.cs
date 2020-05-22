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
    public partial class UpdatePaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    if(us.RoleID == 1)
                    {
                        GridViewUpdatePayment.DataSource = ViewPaymentTypeController.getAllPaymentType();
                        GridViewUpdatePayment.DataBind();
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
        }

        protected void UpdatePT(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdatePaymentTypes.aspx?id=" + id);
        }
    }
}