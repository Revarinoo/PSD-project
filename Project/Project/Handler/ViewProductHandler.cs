using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ViewProductHandler
    {
        public static List<DetailedProduct> getProduct()
        {
            return ProductRepository.getProduct();
        }
    }
}