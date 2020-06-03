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
            TokobediaReport report = new TokobediaReport();
            LoadReport(report);
            TransactionReportViewer.ReportSource = report;
        }

        private void LoadReport(TokobediaReport report)
        {
            DataSet1 dataset = TransactionReportController.getTransactionReportDataSet();
            report.SetDataSource(dataset);
        }
    }
}