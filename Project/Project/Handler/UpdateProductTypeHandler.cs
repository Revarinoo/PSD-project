using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class UpdateProductTypeHandler
    {
        public static List<ProductType> getAllProductType()
        {
            return ProductTypeRepository.getAllPT();
        }

        public static void updateProductType(int ptID, string name, string desc)
        {
            ProductTypeRepository.UpdateProductType(ptID, name, desc);
        }
    }
}