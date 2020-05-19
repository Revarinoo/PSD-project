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
    public partial class AddtoCart : System.Web.UI.Page
    {
        int newID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    if(us.RoleID == 2)
                    {
                        string updID = Request.QueryString["id"];
                        newID = int.Parse(updID);
                        GridViewAddCart.DataSource = AddtoCartController.getInfo(newID).ToList();
                        GridViewAddCart.DataBind();
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

        protected void AddtoCart_Click(object sender, EventArgs e)
        {
            string updID = Request.QueryString["id"];
            newID = int.Parse(updID);
            User us = (User)Session["user"];
            string errorMsg = "";
            lblNotif.Visible = true;
            try
            {
                int quantity = Int32.Parse(Quantity.Text.ToString());
                bool success = AddtoCartController.validateInput(us.UserID, newID, quantity, out errorMsg);
                if (!success)
                {
                    lblNotif.Text = errorMsg;
                }
                else
                {
                    Response.Redirect("ViewCart.aspx");
                }
            }
            catch
            {
                lblNotif.Text = "Must be numeric";
            }

        }
    }
}