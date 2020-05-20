using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class InsertProductTypeHandler
    {
        public static void insertPT(string name, string desc)
        {
            ProductTypeRepository.insertProductType(name, desc);
        }

        public static ProductType searchByName(string name)
        {
            return ProductTypeRepository.SearchByName(name);
        }
    }
}