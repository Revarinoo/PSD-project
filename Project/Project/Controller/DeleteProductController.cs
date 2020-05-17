using Project.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class DeleteProductController
    {
        public static void deleteProduct(int id)
        {
            DeleteProductHandler.deleteProduct(id);
        }

        public static bool validateDelete(int id, out string errorMsg)
        {
            errorMsg = "";
            if (id == null)
            {
                errorMsg = "Data must be filled!";
                return false;
            }
            else
            {
                var p = DeleteProductHandler.searchProductByID(id);
                var dt = DeleteProductHandler.searchDetailTransactionByID(id);
                if ((p != null) && (dt == null))
                {
                    errorMsg = "Success!";
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
}