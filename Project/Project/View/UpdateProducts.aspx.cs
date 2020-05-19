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
    public partial class UpdateProducts : System.Web.UI.Page
    {
        int newID;
        TokobediaEntities dbEntity = new TokobediaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User us = (User)Session["user"];
            if (Session["user"] != null)
            {
                if (us.RoleID == 1)
                {
                    string updID = Request.QueryString["ProductID"];
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

        protected void btnUpdateP_Click(object sender, EventArgs e)
        {
            LabelPr.Visible = true;
            try
            {
                string name = UpdatePName.Text.ToString();
                int stock = Int32.Parse(UpdateStock.Text.ToString());
                int price = Int32.Parse(UpdatePrice.Text.ToString());
                string errorMsg = "";
                bool success = UpdateProductController.validateUpdate(name, stock, price, out errorMsg);
                if (!success)
                {
                    LabelPr.Text = errorMsg;
                }
                else
                {
                    if (success)
                    {
                        LabelPr.Text = newID.ToString();
                        UpdateProductController.updateProduct(newID, name, price, stock);
                        Response.Redirect("UpdateProduct.aspx");
                    }
                    else
                    {
                        LabelPr.Text = errorMsg;
                    }
                }
            }
            catch
            {
                LabelPr.Text = "Cannot be empty!";
            }

        }
    }
}