using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class TransactionHandler
    {
        public static void deleteAllCart(int userID)
        {
            CartRepository.deleteAllCart(userID);
        }

        public static void insertHT(int userID, int paymentTypeID)
        {
            HeaderTransactionRepository.insertHeaderTransaction(userID, paymentTypeID);
        }

        public static void insertDT(int transactionID, int productID, int quantity)
        {
            DetailTransactionRepository.insertDetailTransaction(transactionID, productID, quantity);
        }

        public static int searchByName(string paymentTypeName)
        {
            return PaymentTypeRepository.searchByName(paymentTypeName);
        }

        public static int countCart()
        {
            return CartRepository.count();
        }
    }
}