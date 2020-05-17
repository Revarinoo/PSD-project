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
    public partial class DeleteProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User us = (User)Session["user"];
            if (Session["user"] != null)
            {
                if (us.RoleID == 1)
                {
                    GridViewDelP.DataSource = ViewProductController.getAllProduct();
                    GridViewDelP.DataBind();
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

        protected void btnDeleteP_Click(object sender, EventArgs e)
        {
            TokobediaEntities dbEntity = new TokobediaEntities();
            LabelDelP.Visible = true;
            try
            {
                int id = int.Parse(DeleteProductID.Text.ToString());
                string errorMsg = "";
                bool success = DeleteProductController.validateDelete(id, out errorMsg);
                if (!success)
                {
                    LabelDelP.Text = errorMsg;
                }
                else
                {
                    if (success)
                    {
                        DeleteProductController.deleteProduct(id);
                        GridViewDelP.DataSource = ViewProductController.getAllProduct();
                        GridViewDelP.DataBind();
                        LabelDelP.Text = errorMsg;
                    }
                    else
                    {
                        LabelDelP.Text = errorMsg;
                    }
                }
            }
            catch
            {
                LabelDelP.Text = "Cannot be empty!";
            }
        }
    }
}