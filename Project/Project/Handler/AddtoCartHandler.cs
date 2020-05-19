using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class AddtoCartHandler
    {
        public static List<ProductInfo> productInfo(int productID)
        {
            return ProductRepository.productInfo(productID);
        }
        
        public static List<Product> getStock(int productID)
        {
            return ProductRepository.currentStock(productID);
        }

        public static int getQuantity(int productID)
        {
            return CartRepository.getQuantity(productID);
        }

        public static bool checkCart(int userID, int productID)
        {
            return CartRepository.checkCart(userID, productID);
        }

        public static void updateQuantity(int userID, int productID, int qty)
        {
            CartRepository.updateQuantity(userID, productID, qty);
        }

        public static void addCart(int userID, int productID, int qty)
        {
            CartRepository.addCart(userID, productID, qty);
        }
    }
}