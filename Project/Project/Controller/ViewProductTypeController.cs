using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ViewProductTypeController
    {
        public static List<ProductType> getAllPT()
        {
            return ViewProductTypeHandler.getAllPT();
        }

        public static bool validateDelete(int ptID, out string errorMsg)
        {
            errorMsg = "";
            var p = ViewProductTypeHandler.searchProductByID(ptID);
            var pt = ViewProductTypeHandler.searchPTByID(ptID);
            if((p == null) && (pt != null))
            {
                ViewProductTypeHandler.deletePT(ptID);
                return true;
            }
            else
            {
                errorMsg = "Failed!";
                return false;
            }
        }
    }
}