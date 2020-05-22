using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class PaymentTypeFactory
    {
        public static PaymentType insertPayment(string type)
        {
            PaymentType payment = new PaymentType();
            payment.Type = type;
            return payment;
        }
    }
}