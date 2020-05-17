using Project.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class UpdateProductController
    {
        public static void updateProduct(int id, string name, int price, int stock)
        {
            UpdateProductHandler.updateProduct(id, name, price, stock);
        }

        public static bool validateUpdate(string name, int stock, int price, out string errorMsg)
        {
            errorMsg = "";
            if(name == "")
            {
                errorMsg = "Data must be filled!";
                return false;
            }
            else if (stock <= 1)
            {
                errorMsg = "Input must be 1 or more";
                return false;
            }
            else
            {
                    var product = UpdateProductHandler.validateInsert(stock, price);
                    if(product != null && !name.Equals(""))
                    {
                        return true;
                    }
                    else
                    {
                        errorMsg = "Input must be above 1000 and multiply of 1000";
                        return false;
                    }
            }
        }
    }
}