using Project.Controller;
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
    public partial class ViewProduct : System.Web.UI.Page
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewProduct.Columns[0].Visible = false;
                GridViewProduct.Columns[1].Visible = false;
                GridViewProduct.Columns[2].Visible = false;
                GridViewProduct.Columns[3].Visible = false;
                User us = (User)Session["user"];
                if (Session["user"] != null)
                {
                    if (us.RoleID == 1)
                    {
                        GridViewProduct.Columns[1].Visible = true;
                        GridViewProduct.Columns[2].Visible = true;
                        GridViewProduct.Columns[3].Visible = true;
                    }
                    else if(us.RoleID == 2)
                    {
                        GridViewProduct.Columns[0].Visible = true;
                    }
                }
                GridViewProduct.DataSource = ViewProductController.getAllProduct();
                GridViewProduct.DataBind();
            }
        }

        protected void AddCart_Click(object send, EventArgs e)
        {
            int id = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("AddtoCart.aspx?id=" + id);
        }

        protected void InsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void UpdateProduct_Click(object send, EventArgs e)
        {
            int ProductID = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("UpdateProducts.aspx?ProductID=" + ProductID);
        }

        protected void DeleteProduct_Click(object send, EventArgs e)
        {
            int ProductID = Int32.Parse((send as LinkButton).CommandArgument);
            string errorMsg = "";
            bool success = ViewProductController.validateDelete(ProductID, out errorMsg);
            if (success)
            {
                ViewProductController.deleteProduct(ProductID);
                Response.Redirect("ViewProduct.aspx");
            }   
            else
            {
                lblDelete.Visible = true;
                lblDelete.Text = errorMsg;
            }

        }

        protected void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProduct.aspx");
        }

        protected void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteProduct.aspx");
        }
    }
}