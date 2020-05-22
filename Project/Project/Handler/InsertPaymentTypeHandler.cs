using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class InsertPaymentTypeHandler
    {
        public static void insertPaymentType(string type)
        {
            PaymentTypeRepository.insertPaymentType(type);
        }

        public static PaymentType searchPayment(string type)
        {
            return PaymentTypeRepository.searchPayment(type);
        }
    }
}