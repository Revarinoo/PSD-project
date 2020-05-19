using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class PaymentTypeRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();

        public static List<PaymentType> getAllPaymentType()
        {
            return dbEntity.PaymentTypes.ToList();
        }

        public static int searchByName(string paymentTypeName)
        {
            var id = (from x in dbEntity.PaymentTypes
                      where x.Type == paymentTypeName
                      select x).FirstOrDefault();
            return id.PaymentTypeID;
        }
    }
}