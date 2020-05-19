using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class HeaderTransactionFactory
    {
        public static HeaderTransaction addHeaderTransaction(int userID, int paymentTypeID)
        {
            HeaderTransaction ht = new HeaderTransaction();
            ht.UserID = userID;
            ht.PaymentTypeID = paymentTypeID;
            ht.Date = DateTime.Now;
            return ht;
        }
    }
}