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
                if(Session["user"] != null)
                {
                    User us = (User)Session["user"];
                    if(us.RoleID == 1)
                    {
                        CrystalReport1 report = new CrystalReport1();
                        LoadReport(report);
                        TransactionReportViewer.ReportSource = report;
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

        private void LoadReport(CrystalReport1 report)
        {
            DataSet1 dataset = TransactionReportController.getTransactionReportDataSet();
            report.SetDataSource(dataset);
        }
    }
}