using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class ProductFactory
    {
        public static Product InsertProduct(int typeID, String name, int price, int stock)
        {
            Product prd = new Product();
            prd.ProductTypeID = typeID;
            prd.Name = name;
            prd.Price = price;
            prd.Stock = stock;
            return prd;
        }
    }
}