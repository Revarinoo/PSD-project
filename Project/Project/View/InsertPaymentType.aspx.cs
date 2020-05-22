﻿using Project.Controller;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class InsertPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    if (us.RoleID != 1)
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
        protected void btnInsertPT_Click(object sender, EventArgs e)
        {
            string name = typeName.Text.ToString();
            string errorMsg = "";
            lblInfo.Visible = true;
            bool success = InsertPaymentTypeController.validateInsert(name, out errorMsg);
            if (success)
            {
                lblInfo.Text = errorMsg;
                Response.Redirect("ViewPaymentType.aspx");
            }
            else
            {
                lblInfo.Text = errorMsg;
            }
        }
    }
}