using Project.Factory;
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
        
        public static ProductType searchPTByID(int productTypeID)
        {
            return (from x in dbEntity.ProductTypes
                    where x.ProductTypeID == productTypeID
                    select x).FirstOrDefault();
        }

        public static void DeleteProductType(int id)
        {
            ProductType pt = (ProductType)dbEntity.ProductTypes.Where(a => a.ProductTypeID == id).FirstOrDefault();
            dbEntity.ProductTypes.Remove(pt);
            dbEntity.SaveChanges();
        }

        public static void insertProductType(string name, string desc)
        {
            ProductType pt = ProductTypeFactory.insertProductType(name, desc);
            dbEntity.ProductTypes.Add(pt);
            dbEntity.SaveChanges();
        }

        public static void UpdateProductType(int id, string name, string desc)
        {
            ProductType pt = (ProductType)dbEntity.ProductTypes.Where(a => a.ProductTypeID == id).FirstOrDefault();
            pt.Name = name;
            pt.Description = desc;
            dbEntity.SaveChanges();
        }
    }
}