using Project.Handler;
using Project.Model;
using Project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class TransactionReportController
    {
        public static TokobediaDataSet getTransactionReportDataSet()
        {
            TokobediaDataSet dataset = new TokobediaDataSet();
            var headerTransaction = dataset.HeaderTransaction;
            var detailTransaction = dataset.DetailTransaction;

            List<HeaderTransaction> header = TransactionReportHandler.getAllHeaderTransaction();

            foreach (HeaderTransaction h in header)
            {
                var row = headerTransaction.NewRow();
                row["TransactionID"] = h.TransactionID;
                row["TransactionDate"] = h.Date;
                row["UserID"] = h.UserID;
                row["PaymentTypeID"] = h.PaymentTypeID;
                headerTransaction.Rows.Add(row);

                List<DetailTransaction> details = TransactionReportHandler.getDetailTransaction(h.TransactionID);

                foreach (DetailTransaction d in details)
                {
                    var rowDetail = detailTransaction.NewRow();
                    rowDetail["TransactionID"] = d.TransactionID;
                    rowDetail["ProductID"] = d.ProductID;
                    rowDetail["ProductName"] = d.Product.Name;
                    rowDetail["ProductPrice"] = d.Product.Price;
                    rowDetail["Quantity"] = d.Quantity;
                    detailTransaction.Rows.Add(rowDetail);
                }
            }
            return dataset;
        }
    }
}