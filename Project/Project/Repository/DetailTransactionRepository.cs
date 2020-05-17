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
    }
}