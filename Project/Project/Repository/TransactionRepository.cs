using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class TransactionRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();
        public static List<DetailedTransactionHistories> getTransactionHistories(int userID)
        {
            var history = (from ht in dbEntity.HeaderTransactions
                           join dt in dbEntity.DetailTransactions
                           on ht.TransactionID equals dt.TransactionID
                           join pt in dbEntity.PaymentTypes
                           on ht.PaymentTypeID equals pt.PaymentTypeID
                           join p in dbEntity.Products
                           on dt.ProductID equals p.ProductID
                           where ht.UserID == userID
                           select new DetailedTransactionHistories()

                           {
                               TransactionDate = ht.Date.Date,
                               PaymentType = pt.Type,
                               ProductName = p.Name,
                               ProductQuantity = dt.Quantity,
                               Subtotal = dt.Quantity * p.Price
                           });
            return history.ToList();
        }

        public static List<DetailedTransactionHistories> getAllTransactionHistory()
        {
            var history = (from ht in dbEntity.HeaderTransactions
                           join dt in dbEntity.DetailTransactions
                           on ht.TransactionID equals dt.TransactionID
                           join pt in dbEntity.PaymentTypes
                           on ht.PaymentTypeID equals pt.PaymentTypeID
                           join p in dbEntity.Products
                           on dt.ProductID equals p.ProductID
                           select new DetailedTransactionHistories()

                           {
                               TransactionDate = ht.Date.Date,
                               PaymentType = pt.Type,
                               ProductName = p.Name,
                               ProductQuantity = dt.Quantity,
                               Subtotal = dt.Quantity * p.Price
                           });
            return history.ToList();
        }
    }
}