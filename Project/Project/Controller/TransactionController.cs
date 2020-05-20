using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class TransactionController
    {
        public static void deleteAllCart(int userID)
        {
            TransactionHandler.deleteAllCart(userID);
        }

        public static void insertHT(int userID, int paymentTypeID)
        {
            TransactionHandler.insertHT(userID, paymentTypeID);
        }

        public static void insertDT(int transactionID, int productID, int quantity)
        {
            TransactionHandler.insertDT(transactionID, productID, quantity);
        }

        public static int searchByName(string name)
        {
            return TransactionHandler.searchByName(name);
        }

        public static int countCart()
        {
            return TransactionHandler.countCart();
        }

        public static void checkOut(int userID, int paymentTypeID)
        {
            List<Cart> cartList = TransactionHandler.getAllUserCart(userID);
            int transactionID = TransactionHandler.insertHT(userID, paymentTypeID);
            foreach(Cart cart in cartList)
            {
                insertDT(transactionID, cart.ProductID, cart.Quantity);
            }
            deleteAllCart(userID);
        }
    }
}