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

                           join p in dbEntity.Products
                           on dt.ProductID equals p.ProductID

                           join pt in dbEntity.PaymentTypes
                           on ht.PaymentTypeID equals pt.PaymentTypeID

                           join c in dbEntity.Carts
                           on ht.UserID equals c.UserID
                           where ht.UserID == userID
                           select new DetailedTransactionHistories()

                           {
                               TransactionDate = ht.Date,
                               PaymentType = pt.Type,
                               ProductName = p.Name,
                               ProductQuantity = c.Quantity,
                               Subtotal = c.Quantity * p.Price
                           });
            return history.ToList();
        }

        public static List<DetailedTransactionHistories> getAllTransactionHistory()
        {
            var history = (from ht in dbEntity.HeaderTransactions

                           join dt in dbEntity.DetailTransactions
                           on ht.TransactionID equals dt.TransactionID

                           join p in dbEntity.Products
                           on dt.ProductID equals p.ProductID

                           join pt in dbEntity.PaymentTypes
                           on ht.PaymentTypeID equals pt.PaymentTypeID

                           join c in dbEntity.Carts
                           on ht.UserID equals c.UserID
                           select new DetailedTransactionHistories()

                           {
                               TransactionDate = ht.Date,
                               PaymentType = pt.Type,
                               ProductName = p.Name,
                               ProductQuantity = c.Quantity,
                               Subtotal = c.Quantity * p.Price
                           });
            return history.ToList();
        }
    }
}