using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class UpdatePaymentTypeController
    {
        public static bool validateUpdate(int ptID, string type, out string errorMsg)
        {
            errorMsg = "";
            PaymentType pt = UpdatePaymentTypeHandler.searchByName(type);
            if (type == "")
            {
                errorMsg = "Data must be filled!";
                return false;
            }
            else if (pt == null && type.Length >= 3)
            {
                UpdatePaymentTypeHandler.updatePaymentType(ptID, type);
                return true;
            }
            else
            {
                if (type.Length < 3)
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

        public static List<PaymentType> getAllPaymentType()
        {
            return UpdatePaymentTypeHandler.getAllPaymentType();
        }
    }
}