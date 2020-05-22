using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class InsertPaymentTypeController
    {
        public static bool validateInsert(string type, out string errorMsg)
        {
            errorMsg = "";
            PaymentType pt = InsertPaymentTypeHandler.searchPayment(type);
            if (type == "")
            {
                errorMsg = "Must be filled";
                return false;
            }
            else if(pt == null && type.Length >= 3) 
            {
                InsertPaymentTypeHandler.insertPaymentType(type);
                return true;
            }
            else
            {
                if(type.Length < 3)
                {
                    errorMsg = "Payment Type must consist of 3 characters or more!";
                    return false;
                }
                else
                {
                    errorMsg = "Payment Type already exists!";
                    return false;
                }
            }
        }
    }
}