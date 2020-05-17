using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class HomeHandler
    {
        public static int getMax()
        {
            return ProductRepository.getMax();
        }

        public static int getMin()
        {
            return ProductRepository.getMin();
        }

        public static bool checkProduct(int id)
        {
            return ProductRepository.checkProduct(id);
        }

        public static List<Product> addRandomProduct(int a, int b, int c, int d, int e)
        {
            return ProductRepository.addRandomProduct(a, b, c, d, e);
        }
    }
}