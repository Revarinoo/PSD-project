using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ViewCartController
    {
        public static List<DetailedCart> getCart(int userID)
        {
            return ViewCartHandler.getCart(userID);
        }

        public static Int64 getGrandTotal(int id)
        {
            return ViewCartHandler.calculateGrandTotal(id);
        }

        public static void deleteCart(int userID, int productID)
        {
            ViewCartHandler.deleteCart(userID, productID);
        }

        public static List<PaymentType> getPaymentType()
        {
            return ViewCartHandler.getAllPaymentType();
        } 
    }
}