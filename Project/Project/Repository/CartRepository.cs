using Project.Factory;
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

        public static List<Cart> getAllUserCart(int userID)
        {
            var cart = (from x in dbEntity.Carts
                        where x.UserID == userID
                        select x);
            return cart.ToList();
        }

        public static List<DetailedCart> getCart(int userID)
        {
            var cart = (from x in dbEntity.Products join y in dbEntity.Carts
                        on x.ProductID equals y.ProductID
                        where y.UserID == userID
                        select new DetailedCart()
                        {
                            ID = x.ProductID,
                            Name = x.Name,
                            Price = x.Price,
                            Quantity = y.Quantity,
                            Subtotal = y.Quantity * x.Price
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

        public static int getQuantity(int productID)
        {
            int total = 0;
            var qty = (from x in dbEntity.Carts
                       where x.ProductID == productID
                       select new
                       {
                           x.Quantity
                       });
            foreach(var item in qty)
            {
                total += item.Quantity;
            }
            return total;
        }

        public static void deleteCart(int userID, int productID)
        {
            Cart cart = (from x in dbEntity.Carts
                         where x.UserID == userID && x.ProductID == productID
                         select x).FirstOrDefault();
            dbEntity.Carts.Remove(cart);
            dbEntity.SaveChanges();
        }

        public static void deleteAllCart(int userID)
        {
            var cart = dbEntity.Carts.Where(c => c.UserID == userID).ToList();
            cart.ForEach(c =>
            {
                dbEntity.Entry(c).State = System.Data.Entity.EntityState.Deleted;
            });
            dbEntity.SaveChanges();
        }

        public static int count()
        {
            return dbEntity.Carts.Count();
        }

        public static bool checkCart(int userID, int productID)
        {
            var available = (from x in dbEntity.Carts
                             where x.UserID == userID && x.ProductID == productID
                             select x).FirstOrDefault();
            if(available != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void updateQuantity(int userID ,int productID, int qty)
        {
            Cart cart = (Cart)dbEntity.Carts.Where(c => c.UserID == userID && c.ProductID == productID).FirstOrDefault();
            cart.Quantity = qty;
            dbEntity.SaveChanges();
        }

        public static void addCart(int userID, int productID, int qty)
        {
            Cart cart = CartFactory.addCart(userID, productID, qty);
            dbEntity.Carts.Add(cart);
            dbEntity.SaveChanges();
        }

        public static List<DetailedCart> getSelectedCart(int userID, int productID)
        {
            var cart = (from x in dbEntity.Products join y in dbEntity.Carts
                        on x.ProductID equals y.ProductID
                        where y.UserID == userID && y.ProductID == productID
                        select new DetailedCart()
                        {
                            ID = x.ProductID,
                            Name = x.Name,
                            Price = x.Price,
                            Quantity = y.Quantity,
                            Subtotal = y.Quantity * x.Price
                        });
            return cart.ToList();
        }
    }
}