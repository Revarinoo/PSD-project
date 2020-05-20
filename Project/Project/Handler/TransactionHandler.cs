using Project.Model;
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

        public static int insertHT(int userID, int paymentTypeID)
        {
            int transactionID = HeaderTransactionRepository.insertHeaderTransaction(userID, paymentTypeID);
            return transactionID;
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

        public static List<Cart> getAllUserCart(int userID)
        {
            return CartRepository.getAllUserCart(userID);
        }
        
    }
}