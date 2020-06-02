using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class TransactionReportHandler
    {
        public static List<HeaderTransaction> getAllHeaderTransaction()
        {
            return HeaderTransactionRepository.getAllHeaderTransaction();
        }

        public static List<DetailTransaction> getDetailTransaction(int transactionID)
        {
            return DetailTransactionRepository.getDetailTransaction(transactionID);
        }
    }
}