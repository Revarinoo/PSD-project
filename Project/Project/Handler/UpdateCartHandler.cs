using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class UpdateCartHandler
    {
        public static void updateQuantity(int userID, int productID, int qty)
        {
            CartRepository.updateQuantity(userID, productID, qty);
        }

        public static void deleteCart(int userID, int productID)
        {
            CartRepository.deleteCart(userID, productID);
        }

        public static List<DetailedCart> getSelectedCart(int userID, int productID)
        {
            return CartRepository.getSelectedCart(userID, productID);
        }
    }
}