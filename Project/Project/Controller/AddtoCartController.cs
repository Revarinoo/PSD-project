using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class AddtoCartController
    {
        public static List<ProductInfo> getInfo(int productID)
        {
            return AddtoCartHandler.productInfo(productID);
        } 

        public static void addCart(int userID, int productID, int qty)
        {
            AddtoCartHandler.addCart(userID, productID, qty);
        }

        public static bool validateInput(int userID, int productID ,int qty, out string errorMsg)
        {
            errorMsg = "";
            int totalReserved = qty + AddtoCartHandler.getQuantity(productID);
            var total = AddtoCartHandler.getStock(productID);
            bool available = AddtoCartHandler.checkCart(userID, productID);
            if (qty <= 0)
            {
                errorMsg = "Must be more than 0";
                return false;
            }
            else if (qty > total.Select(p=>p.Stock).FirstOrDefault() || totalReserved > total.Select(p => p.Stock).FirstOrDefault())
            {
                errorMsg = "Stock not available";
                return false;
            }
            else if (available == true)
            {
                AddtoCartHandler.updateQuantity(userID, productID, qty);
                return true;
            }
            else
            {
                addCart(userID, productID, qty);
                return true;
            }
        }
    }
}