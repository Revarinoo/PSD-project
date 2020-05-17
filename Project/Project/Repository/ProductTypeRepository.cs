using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class ProductTypeRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();
        public static ProductType SearchByName(string type)
        {
            return (from x in dbEntity.ProductTypes
                    where x.Name == type
                    select x).FirstOrDefault();
        }

        public static List<DetailedProduct> getProductTypeName()
        {
            var pt = (from x in dbEntity.ProductTypes
                      select new DetailedProduct()
                      {
                          ProductTypeName = x.Name
                      });
            return pt.ToList();
        }

        public static List<ProductType> getAllPT()
        {
            return dbEntity.ProductTypes.ToList();
        }
        
    }
}