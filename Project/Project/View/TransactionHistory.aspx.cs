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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User us = (User)Session["user"];
                if(Session["user"] != null)
                {
                    if(us.RoleID == 1)
                    {
                        // admin do something
                        GridTransactionHistory.DataSource = TransactionHistoryController.getAllTransactionHistory();
                    }
                    else
                    {
                        int userID = us.UserID;
                        GridTransactionHistory.DataSource = TransactionHistoryController.getTransactionHistory(userID);
                        GridTransactionHistory.DataBind();
                    }
                }
            }
        }
    }
}