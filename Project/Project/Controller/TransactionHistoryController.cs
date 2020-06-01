using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class TransactionHistoryController
    {
        public static List<DetailedTransactionHistories> getTransactionHistory(int userID)
        {
            return TransactionHistoryHandler.getTransactionHistory(userID);
        }

        public static List<DetailedTransactionHistories> getAllTransactionHistory()
        {
            return TransactionHistoryHandler.getAllTransactionHistory();
        }
    }
}