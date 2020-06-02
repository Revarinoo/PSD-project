﻿using Project.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class ViewTransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport report = new TransactionReport();
            TransactionReportViewer.ReportSource = report;
        }

        private void loadReport (TransactionReport report)
        {
            TokobediaDataSet dataset = TransactionController.getTransactionReportDataSet();
        }
    }
}