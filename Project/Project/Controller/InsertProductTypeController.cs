using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class InsertProductTypeController
    {
        public static bool validateInsert(string name, string desc, out string errorMsg)
        {
            errorMsg = "";
            ProductType pt = InsertProductTypeHandler.searchByName(name);
            if(name == "" || desc == "")
            {
                errorMsg = "Cannot be empty";
                return false;
            }
            else if(pt == null && name.Length >= 5)
            {
                InsertProductTypeHandler.insertPT(name, desc);
                errorMsg = "Success";
                return true;
            }
            else
            {
                if(name.Length < 5)
                {
                    errorMsg = "Product Type must consist of 5 characters or more!";
                    return false;
                }
                else
                {
                    errorMsg = "Product Type Name already exists!";
                    return false;
                }
            }
        }
    }
}