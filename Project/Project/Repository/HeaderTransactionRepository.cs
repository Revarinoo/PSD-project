using Project.Factory;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class HeaderTransactionRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();

        public static void insertHeaderTransaction(int userID, int paymentTypeID)
        {
            HeaderTransaction ht = HeaderTransactionFactory.addHeaderTransaction(userID, paymentTypeID);
            dbEntity.HeaderTransactions.Add(ht);
            dbEntity.SaveChanges();
        }

        public static int getTransactionID()
        {
            return dbEntity.HeaderTransactions.Max(ht => ht.TransactionID);
        }

        
    }
}