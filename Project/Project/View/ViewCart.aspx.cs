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
                    if(us.RoleID == 2)
                    {
                        var data = ViewCartController.getCart(us.UserID);
                        GridViewCart.DataSource = data.ToList();
                        GridViewCart.DataBind();
                        if(data.Count != 0)
                        {
                            GridViewCart.FooterRow.Cells[0].Text = "Grand Total";
                            GridViewCart.FooterRow.Cells[5].Font.Bold = true;
                            GridViewCart.FooterRow.Cells[5].Text = ViewCartController.getGrandTotal(us.UserID).ToString();
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

        protected void UpdateCart_Click(object send, EventArgs e)
        {
            int ProductID = Int32.Parse((send as LinkButton).CommandArgument);
            Response.Redirect("UpdateCart.aspx?id=" + ProductID);
        }

        //protected void DeleteCart_Click(object send, EventArgs e)
        //{
        //    int UserID = Int32.Parse((send as LinkButton).CommandArgument);
        //    int ProductID = Int32.Parse((send as LinkButton).CommandArgument);
        //    Response.Redirect("DeleteCart.aspx?UserID=" + UserID + "ProductID=" + ProductID);
        //}
    }
}