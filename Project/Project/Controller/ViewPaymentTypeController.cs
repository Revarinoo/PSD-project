using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ViewPaymentTypeController
    {
        public static List<PaymentType> getAllPaymentType()
        {
            return ViewPaymentTypeHandler.getAllPaymentType();
        }
    }
}