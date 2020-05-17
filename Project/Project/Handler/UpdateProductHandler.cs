using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class UpdateProductHandler
    {
        public static void updateProduct(int id, string name, int price, int stock)
        {
            ProductRepository.UpdateProduct(id, name, price, stock);
        }

        public static Product validateInsert(int stock, int price)
        {
            return ProductRepository.validateInsert(stock, price);
        }
    }
}