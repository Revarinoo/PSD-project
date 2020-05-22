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
    public partial class ViewPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    if (us.RoleID == 1)
                    {
                        GridViewPayment.DataSource = ViewPaymentTypeController.getAllPaymentType();
                        GridViewPayment.DataBind();
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

        protected void InsertPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType.aspx");
        }

        protected void UpdatePaymentType_Click(object send, EventArgs e)
        {
            int id = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("UpdatePaymentTypes.aspx?id=" + id);
        }

        protected void DeletePaymentType_Click(object send, EventArgs e)
        {
            int id = Int32.Parse((send as LinkButton).CommandArgument);
            string errorMsg = "";
            bool success = DeletePaymentTypeController.validateDelete(id, out errorMsg);
            if (success)
            {
                Response.Redirect("ViewPaymentType.aspx");
            }
            else
            {
                lblDelete.Visible = true;
                lblDelete.Text = errorMsg;
            }
        }
    }
}