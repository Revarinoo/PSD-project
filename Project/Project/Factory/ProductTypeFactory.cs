using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class ProductTypeFactory
    {
        public static ProductType insertProductType(string name, string desc)
        {
            ProductType pt = new ProductType();
            pt.Name = name;
            pt.Description = desc;
            return pt;
        }
    }
}