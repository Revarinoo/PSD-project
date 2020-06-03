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
                        btnChangePassword.Visible = true;
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
            btnChangePassword.Visible = false;
            btnViewTransactionHistory.Visible = false;
            btnViewUser.Visible = false;
            btnInsertProduct.Visible = false;
            btnUpdateProduct.Visible = false;
            btnViewProductType.Visible = false;
            btnInsertProductType.Visible = false;
            btnUpdateProductType.Visible = false;
            GridViewCart.Columns[0].Visible = false;
            LblMessage.Visible = false;
            btnViewPaymentType.Visible = false;
            btnInsertPaymentType.Visible = false;
            btnUpdatePaymentType.Visible = false;
            btnViewTransactionReport.Visible = false;
        }

        private void AdminButton()
        {
            btnChangePassword.Visible = true;
            btnViewTransactionHistory.Visible = true;
            btnViewUser.Visible = true;
            btnInsertProduct.Visible = true;
            btnUpdateProduct.Visible = true;
            btnViewProductType.Visible = true;
            btnInsertProductType.Visible = true;
            btnUpdateProductType.Visible = true;
            btnViewPaymentType.Visible = true;
            btnInsertPaymentType.Visible = true;
            btnUpdatePaymentType.Visible = true;
            btnViewTransactionReport.Visible = true;
        }

        private void random()
        {

            int count = ViewProductController.countProduct();
            if(count < 6)
            {
                var less = ViewProductController.getAllProduct();
                GridViewCart.DataSource = less.ToList();
                GridViewCart.DataBind();
            }
            else
            {
                var pr = ViewProductController.generateRandom();

                GridViewCart.DataSource = pr.ToList();
                GridViewCart.DataBind();
            }
            
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

        protected void DoChangePassword(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
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

        protected void btnPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPaymentType.aspx");
        }

        protected void btnInsertPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType.aspx");
        }

        protected void btnUpdatePaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePaymentType.aspx");
        }

        protected void btnViewTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport.aspx");
        }

        protected void btnViewTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.asp");
        }
    }
}