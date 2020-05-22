using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class DeletePaymentTypeController
    {
        public static void deletePayment(int paymentID)
        {
            DeletePaymentTypeHandler.deletePayment(paymentID);
        }

        public static bool validateDelete(int paymentID, out string errorMsg)
        {
            errorMsg = "";
            HeaderTransaction ht = DeletePaymentTypeHandler.searchByPaymentID(paymentID);
            PaymentType pt = DeletePaymentTypeHandler.searchByID(paymentID);
            if((ht == null) && (pt != null))
            {
                deletePayment(paymentID);
                return true;
            }
            else
            {
                errorMsg = "Failed!";
                return false;
            }
        }
    }
}