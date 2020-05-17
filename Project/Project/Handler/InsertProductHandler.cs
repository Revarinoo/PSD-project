using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class InsertProductHandler
    {
        public static List<ProductType> getAllProductType()
        {
            return ProductTypeRepository.getAllPT();
        }

        public static void InsertProduct(int id , string name, int price, int stock)
        {
            ProductRepository.InsertProduct(id, name, price, stock);
        }

        public static ProductType SearchByName(string type)
        {
            return ProductTypeRepository.SearchByName(type);
        }

        public static Product ValidateInsert(int stock, int price)
        {
            return ProductRepository.validateInsert(stock, price);
        }
    }
}