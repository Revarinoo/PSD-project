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
    public partial class UpdateCart : System.Web.UI.Page
    {
        int newID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    if (us.RoleID == 2)
                    {
                        string updID = Request.QueryString["id"];
                        newID = int.Parse(updID);
                        GridViewUpdateCart.DataSource = UpdateCartController.getSelectedCart(us.UserID, newID);
                        GridViewUpdateCart.DataBind();
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

        protected void UpdateCart_Click(object sender, EventArgs e)
        {
            lblNotif.Visible = true;
            string updID = Request.QueryString["id"];
            newID = int.Parse(updID);
            User us = (User)Session["user"];
            string errorMsg = "";
            try
            {
                int qty = Int32.Parse(Quantity.Text.ToString());
                bool success = UpdateCartController.validateUpdate(us.UserID, newID, qty, out errorMsg);
                if (success)
                {
                    Response.Redirect("ViewCart.aspx");
                }
                else
                {
                    lblNotif.Text = errorMsg;
                }
            }
            catch
            {
                lblNotif.Text = "Input invalid!";
            }

        }
    }
}