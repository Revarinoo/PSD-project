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
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User us = (User)Session["user"];
                if (Session["user"] != null)
                {
                    lblPayment.Visible = false;
                    btnCheckout.Visible = false;
                    DropDownListPaymentType.Visible = false;
                    if (us.RoleID == 2)
                    {
                        var data = ViewCartController.getCart(us.UserID);
                        GridViewCart.DataSource = data.ToList();
                        GridViewCart.DataBind();
                        if(data.Count != 0)
                        {
                            viewCart(us.UserID);   
                        }
                        else
                        {
                            empty.Visible = true;
                        }
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

        private void viewCart(int id)
        {
            lblPayment.Visible = true;
            DropDownListPaymentType.Visible = true;
            GridViewCart.FooterRow.Cells[0].Font.Bold = true;
            GridViewCart.FooterRow.Cells[0].Text = "Grand Total";
            GridViewCart.FooterRow.Cells[6].Font.Bold = true;
            GridViewCart.FooterRow.Cells[6].Text = ViewCartController.getGrandTotal(id).ToString();
            DropDownListPaymentType.DataSource = ViewCartController.getPaymentType().Select(pt => pt.Type).ToList();
            DropDownListPaymentType.DataBind();
            btnCheckout.Visible = true;
        }

        protected void UpdateCart_Click(object send, EventArgs e)
        {
            int ProductID = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("UpdateCart.aspx?id=" + ProductID);
        }

        protected void DeleteCart_Click(object sender, EventArgs e)
        {
            int ProductID = Int32.Parse((sender as LinkButton).CommandArgument);
            User us = (User)Session["user"];
            ViewCartController.deleteCart(us.UserID, ProductID);
            Response.Redirect("ViewCart.aspx");
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            User us = (User)Session["user"];
            string paymentType = DropDownListPaymentType.Text.ToString();
            int paymentID = TransactionController.searchByName(paymentType);
            TransactionController.insertHT(us.UserID, paymentID);
            int TransactionID = HeaderTransactionRepository.getTransactionID();
            int productID = 0;
            int qty = 0;
            foreach (GridViewRow row in GridViewCart.Rows)
            {
                productID = Convert.ToInt32(row.Cells[2].Text);
                qty = Convert.ToInt32(row.Cells[5].Text);
                TransactionController.insertDT(TransactionID, productID, qty);
            }
            TransactionController.deleteAllCart(us.UserID);
            Response.Redirect("ViewCart.aspx");
            
        }
    }
}