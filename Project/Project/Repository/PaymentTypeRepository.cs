using Project.Factory;
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

        public static PaymentType searchPayment(string type)
        {
            return (from x in dbEntity.PaymentTypes
                    where x.Type == type
                    select x).FirstOrDefault();
        }

        public static void deletePayment(int id)
        {
            PaymentType payment = (PaymentType)dbEntity.PaymentTypes.Where(p => p.PaymentTypeID == id).FirstOrDefault();
            dbEntity.PaymentTypes.Remove(payment);
            dbEntity.SaveChanges();
        }

        public static PaymentType searchByID(int paymentID)
        {
            return (from x in dbEntity.PaymentTypes
                    where x.PaymentTypeID == paymentID
                    select x).FirstOrDefault();
        }

        public static void insertPaymentType(string type)
        {
            PaymentType payment = PaymentTypeFactory.insertPayment(type);
            dbEntity.PaymentTypes.Add(payment);
            dbEntity.SaveChanges();
        }

        public static void updatePaymentType(int paymentID, string type)
        {
            PaymentType payment = (PaymentType)dbEntity.PaymentTypes.Where(p => p.PaymentTypeID == paymentID).FirstOrDefault();
            payment.Type = type;
            dbEntity.SaveChanges();
        }
    }
}