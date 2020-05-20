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
    public partial class ViewProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    GridViewPT.Columns[0].Visible = false;
                    GridViewPT.Columns[1].Visible = false;
                    GridViewPT.Columns[2].Visible = false;
                    if (us.RoleID == 1)
                    {
                        GridViewPT.Columns[0].Visible = true;
                        GridViewPT.Columns[1].Visible = true;
                        GridViewPT.Columns[2].Visible = true;
                        GridViewPT.DataSource = ViewProductTypeController.getAllPT();
                        GridViewPT.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }

        protected void InsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void UpdateProductType_Click(object send, EventArgs e)
        {
            int id = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("UpdateProductTypes.aspx?id=" + id);
        }

        protected void DeleteProductType_Click(object send, EventArgs e)
        {
            int id = Int32.Parse((send as LinkButton).CommandArgument);
            string errorMsg = "";
            bool success = ViewProductTypeController.validateDelete(id, out errorMsg);
            if (success)
            {
                Response.Redirect("ViewProductType.aspx");
            }
            else
            {
                lblDelete.Visible = true;
                lblDelete.Text = errorMsg;
            }
        }
    }
}