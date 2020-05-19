using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ViewCartHandler
    {
        public static List<DetailedCart> getCart(int userID)
        {
            return CartRepository.getCart(userID);
        }

        public static Int64 calculateGrandTotal(int id)
        {
            return CartRepository.getGrandTotal(id);
        }

        public static void deleteCart(int userID, int productID)
        {
            CartRepository.deleteCart(userID, productID);
        }

        public static List<PaymentType> getAllPaymentType()
        {
            return PaymentTypeRepository.getAllPaymentType();
        }
        
    }
}