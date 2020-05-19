using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class DetailTransactionFactory
    {
        public static DetailTransaction addDetailTransaction(int transactionID, int productID, int quantity)
        {
            DetailTransaction dt = new DetailTransaction();
            dt.TransactionID = transactionID;
            dt.ProductID = productID;
            dt.Quantity = quantity;
            return dt;
        }
    }
}