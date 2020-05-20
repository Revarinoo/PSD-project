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
    public partial class UpdateProductTypes : System.Web.UI.Page
    {
        int newID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    if(us.RoleID == 1)
                    {
                        string updID = Request.QueryString["id"];
                        newID = int.Parse(updID);
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

        protected void btnUpdatefix_Click(object sender, EventArgs e)
        {
            string name = UpdateTypeName.Text.ToString();
            string desc = UpdateDesc.Text.ToString();
            string updID = Request.QueryString["id"];
            newID = int.Parse(updID);
            string errorMsg = "";
            labelError.Visible = true;
            bool success = UpdateProductTypeController.validateUpdate(newID, name, desc, out errorMsg);
            if (!success)
            {
                labelError.Text = errorMsg;
            }
            else
            {
                Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}