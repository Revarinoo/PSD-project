using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class TransactionHistoryHandler
    {
        public static List<DetailedTransactionHistories> getTransactionHistory(int userID)
        {
            return TransactionRepository.getTransactionHistories(userID);
        }
    }
}