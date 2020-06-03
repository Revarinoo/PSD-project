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
    public partial class ViewTransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User us = (User)Session["user"];
                if(us.RoleID == 1)
                {
            TransactionReport report = new TransactionReport();
            TransactionReportViewer.ReportSource = report;
                }else
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }

        private void loadReport (TransactionReport report)
        {
            TokobediaDataSet dataset = TransactionReportController.getTransactionReportDataSet();
            report.SetDataSource(dataset);
        }
    }
}