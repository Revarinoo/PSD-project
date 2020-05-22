using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class UpdatePaymentTypeHandler
    {
        public static List<PaymentType> getAllPaymentType()
        {
            return PaymentTypeRepository.getAllPaymentType();
        }

        public static void updatePaymentType(int id, string type)
        {
            PaymentTypeRepository.updatePaymentType(id, type);
        }

        public static PaymentType searchByName(string type)
        {
            return PaymentTypeRepository.searchPayment(type);
        }
    }
}