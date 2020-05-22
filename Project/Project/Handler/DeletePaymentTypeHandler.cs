using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class DeletePaymentTypeHandler
    {
        public static void deletePayment(int id)
        {
            PaymentTypeRepository.deletePayment(id);
        }

        public static PaymentType searchByID(int paymentID)
        {
            return PaymentTypeRepository.searchByID(paymentID);
        }

        public static HeaderTransaction searchByPaymentID(int paymentID)
        {
            return HeaderTransactionRepository.searchByPaymentID(paymentID);
        }
    }
}