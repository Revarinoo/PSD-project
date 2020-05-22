using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ViewPaymentTypeHandler
    {
        public static List<PaymentType> getAllPaymentType()
        {
            return PaymentTypeRepository.getAllPaymentType();
        }
    }
}