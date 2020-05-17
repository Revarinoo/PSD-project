using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class CartRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();

        public static List<DetailedCart> getCart(int userID)
        {
            var cart = (from x in dbEntity.Products join y in dbEntity.Carts
                        on x.ProductID equals y.ProductID
                        where y.UserID == userID
                        select new DetailedCart()
                        {
                            ProductID = x.ProductID,
                            ProductName = x.Name,
                            ProductPrice = x.Price,
                            Quantity = y.Quantity,
                            subtotal = y.Quantity * x.Price
                        });
            return cart.ToList();
        }

        public static Int64 getGrandTotal(int id)
        {
            Int64 GrandTotal = 0;
            var cart = (from x in dbEntity.Products join y in dbEntity.Carts
                        on x.ProductID equals y.ProductID
                        where y.UserID == id
                        select new {
                            x.Price,
                            y.Quantity
                        });
            
            foreach(var item in cart)
            {
                Int64 sub = Convert.ToInt32(item.Quantity) * Convert.ToInt64(item.Price);
                GrandTotal += sub;
            }
            return GrandTotal;
        }
    }
}