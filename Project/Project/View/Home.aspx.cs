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
    public partial class Home : System.Web.UI.Page
    {
        TokobediaEntities dbEntity = new TokobediaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            User us = (User)Session["user"];
            SettingButton();
            if (Session["user"] != null)
            {
                if (us.RoleID == 1)
                {
                    AdminButton();
                }
                else if(us.RoleID == 2)
                {
                    GridViewCart.Columns[0].Visible = true;
                }
                
                LblMessage.Visible = true;
                LblMessage.Text = "Welcome " + us.Name + "!";
            }
            
            random();
            }
        }

        private void SettingButton()
        {
            btnViewUser.Visible = false;
            btnInsertProduct.Visible = false;
            btnUpdateProduct.Visible = false;
            btnViewProductType.Visible = false;
            btnInsertProductType.Visible = false;
            btnUpdateProductType.Visible = false;
            GridViewCart.Columns[0].Visible = false;
            LblMessage.Visible = false;
        }

        private void AdminButton()
        {
            btnViewUser.Visible = true;
            btnInsertProduct.Visible = true;
            btnUpdateProduct.Visible = true;
            btnViewProductType.Visible = true;
            btnInsertProductType.Visible = true;
            btnUpdateProductType.Visible = true;
        }

        private void random()
        {
            var pr = ViewProductController.generateRandom();

            GridViewCart.DataSource = pr.ToList();
            GridViewCart.DataBind();
        }

        protected void Cart_Click(object send, EventArgs e)
        {
            int id = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("AddtoCart.aspx?id=" + id);
        }


        protected void DoViewProduct(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProduct.aspx");
        }

        protected void btnViewProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductType.aspx");
        }

        protected void btnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void btnUpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductType.aspx");
        }

        protected void btnViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }


    }
}