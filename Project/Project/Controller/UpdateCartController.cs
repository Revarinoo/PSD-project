using Project.Handler;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class UpdateCartController
    {
        public static List<DetailedCart> getSelectedCart(int userID, int productID)
        {
            return UpdateCartHandler.getSelectedCart(userID, productID);
        }

        public static bool validateUpdate(int userID, int productID, int qty, out string errorMsg)
        {
            int totalReserved = qty + AddtoCartHandler.getQuantity(productID);
            var total = AddtoCartHandler.getStock(productID);
            errorMsg = "";
            if(qty < 0)
            {
                errorMsg = "Input must be higher than 0";
                return false;
            }
            else if(qty == 0)
            {
                UpdateCartHandler.deleteCart(userID, productID);
                return true;
            }
            else if (qty > total.Select(p => p.Stock).FirstOrDefault() || totalReserved > total.Select(p => p.Stock).FirstOrDefault())
            {
                errorMsg = "Stock not available";
                return false;
            }
            else
            {
                UpdateCartHandler.updateQuantity(userID, productID, qty);
                return true;
            }
        }
    }
}