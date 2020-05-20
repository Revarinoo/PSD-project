using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ViewProductTypeHandler
    {
        public static List<ProductType> getAllPT()
        {
            return ProductTypeRepository.getAllPT();
        }

        public static ProductType searchPTByID(int productTypeID)
        {
            return ProductTypeRepository.searchPTByID(productTypeID);
        }

        public static Product searchProductByID(int ptID)
        {
            return ProductRepository.searchPTByID(ptID);
        }

        public static void deletePT(int id)
        {
            ProductTypeRepository.DeleteProductType(id);
        }
    }
}