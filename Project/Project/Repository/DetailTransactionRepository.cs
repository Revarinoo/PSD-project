using Project.Factory;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class DetailTransactionRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();
        public static DetailTransaction searchByID(int id)
        {
            return (from x in dbEntity.DetailTransactions
                    where x.ProductID == id
                    select x).FirstOrDefault();
        }

        public static void insertDetailTransaction(int transactionID, int productID, int quantity)
        {
            DetailTransaction dt = DetailTransactionFactory.addDetailTransaction(transactionID, productID, quantity);
            dbEntity.DetailTransactions.Add(dt);
            dbEntity.SaveChanges();
        }

        public static List<DetailTransaction> getDetailTransaction(int transactionID)
        {
            List<DetailTransaction> detailList = (from x in dbEntity.DetailTransactions where x.TransactionID == transactionID select x).ToList();
            return detailList;
        }
    }
}