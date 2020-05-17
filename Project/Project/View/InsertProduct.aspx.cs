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
    public partial class InsertProduct : System.Web.UI.Page
    {
        TokobediaEntities dbEntity = new TokobediaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User us = (User)Session["user"];
            if (Session["user"] != null)
            {
                if (us.RoleID == 1)
                {
                    if (!IsPostBack)
                    {
                        DropDownListType.DataSource = InsertProductController.getAllProductType().Select(p=>p.Name).ToList();
                        DropDownListType.DataBind();
                    }

                    GridViewInsertProduct.DataSource = ViewProductController.getAllProduct();
                    GridViewInsertProduct.DataBind();
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


        protected void btnInsertP_Click(object sender, EventArgs e)
        {
            LabelInvalid.Visible = true;
            string errorMsg = "";
            try
            {
                string name = productName.Text.ToString();
                int stock = Int32.Parse(productStock.Text.ToString());
                int price = Int32.Parse(productPrice.Text.ToString());
                string type = DropDownListType.Text.ToString();
                bool success = InsertProductController.Insert(name, stock, price, type, out errorMsg);
                if (!success)
                {
                    LabelInvalid.Text = errorMsg;
                }
                else
                {
                    var pt = InsertProductController.SearchByName(type);
                    if (success)
                    {
                        LabelInvalid.Text = errorMsg;
                        InsertProductController.doInsert(pt.ProductTypeID, name, price, stock);
                        GridViewInsertProduct.DataSource = ViewProductController.getAllProduct();
                        GridViewInsertProduct.DataBind();
                    }
                    else
                    {
                        LabelInvalid.Text = errorMsg;
                    }
                }
                
            }catch
            {
                LabelInvalid.Text = "Cannot be empty!";
            }
        }
    }
}