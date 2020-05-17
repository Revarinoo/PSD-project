using Project.Factory;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class ProductRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();
        public static int getMax()
        {
            return dbEntity.Products.Max(p => p.ProductID);
        }

        public static int getMin()
        {
            return dbEntity.Products.Min(p => p.ProductID);
        }

        public static Product searchByID(int id)
        {
            return (from x in dbEntity.Products
                    where x.ProductID == id
                    select x).FirstOrDefault();
        }

        public static bool checkProduct(int id)
        {
            var P = (from x in dbEntity.Products
                     where x.ProductID == id
                     select x).FirstOrDefault();
            if(P == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<Product> addRandomProduct(int a, int b, int c, int d, int e)
        {
            Product cek1 = (from x in dbEntity.Products
                            where x.ProductID == a
                            select x).FirstOrDefault();
            Product cek2 = (from x in dbEntity.Products
                            where x.ProductID == b
                            select x).FirstOrDefault();
            Product cek3 = (from x in dbEntity.Products
                            where x.ProductID == c
                            select x).FirstOrDefault();
            Product cek4 = (from x in dbEntity.Products
                            where x.ProductID == d
                            select x).FirstOrDefault();
            Product cek5 = (from x in dbEntity.Products
                            where x.ProductID == e
                            select x).FirstOrDefault();
            List<Product> pr = new List<Product>();
            pr.Add(cek1);
            pr.Add(cek2);
            pr.Add(cek3);
            pr.Add(cek4);
            pr.Add(cek5);
            return pr;
        }

        public static List<DetailedProduct> getProduct()
        {
            var view = (from x in dbEntity.Products join y in dbEntity.ProductTypes
                        on x.ProductTypeID equals y.ProductTypeID
                        select new DetailedProduct()
                        {
                            ProductID = x.ProductID,
                            ProductName = x.Name,
                            Stock = x.Stock,
                            ProductTypeName = y.Name,
                            Price = x.Price
                       });
            
            return view.ToList();
        }

        public static void InsertProduct(int TypeID, string name, int price, int stock)
        {
            Product prd = ProductFactory.InsertProduct(TypeID, name, price, stock);
            dbEntity.Products.Add(prd);
            dbEntity.SaveChanges();
        }

        public static List<Product> getAllProduct()
        {
            return dbEntity.Products.ToList();
        }

        public static Product validateInsert(int stock, int price)
        {
            return (from z in dbEntity.Products
                    where stock >= 1 && (price > 1000 && price % 1000 == 0)
                    select z).FirstOrDefault();
        }

        public static void UpdateProduct(int id, string name, int price, int stock)
        {
            Product p = (Product)dbEntity.Products.Where(a => a.ProductID == id).FirstOrDefault();
            p.Name = name;
            p.Price = price;
            p.Stock = stock;
            dbEntity.SaveChanges();
        }

        public static void DeleteProduct(int id)
        {
            Product p = (Product)dbEntity.Products.Where(a => a.ProductID == id).FirstOrDefault();
            dbEntity.Products.Remove(p);
            dbEntity.SaveChanges();
        }
    }
}