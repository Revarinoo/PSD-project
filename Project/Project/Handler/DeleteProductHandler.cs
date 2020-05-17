using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class DeleteProductHandler
    {
        public static void deleteProduct(int id)
        {
            ProductRepository.DeleteProduct(id);
        }
        
        public static Product searchProductByID(int id)
        {
            return ProductRepository.searchByID(id);
        }

        public static DetailTransaction searchDetailTransactionByID(int id)
        {
            return DetailTransactionRepository.searchByID(id);
        }
    }
}