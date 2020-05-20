using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class UpdateProductTypeController
    {
        public static List<ProductType> getAllProductType()
        {
            return UpdateProductTypeHandler.getAllProductType();
        }

        public static bool validateUpdate(int ptID, string name, string desc, out string errorMsg)
        {
            errorMsg = "";
            if(name == "" || desc == "")
            {
                errorMsg = "Data must be filled!";
                return false;
            }
            else
            {
                if(name.Length >= 5)
                {
                    UpdateProductTypeHandler.updateProductType(ptID, name, desc);
                    return true;
                }
                else
                {
                    errorMsg = "Product type must consists of 5 characters or more";
                    return false;
                }
            }
        }
    }
}