using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ViewProductController
    {
        public static List<Product> generateRandom()
        {
            int lastID = HomeHandler.getMax();
            int firstID = HomeHandler.getMin();
            Random rand = new Random();
            int[] arr = new int[5];
            int ran = 0;
            int flag;
            int j = 0;
            
            do
            {
                flag = 0;
                ran = rand.Next(firstID, lastID);
                bool IsEmpty = HomeHandler.checkProduct(ran);
                if(IsEmpty == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (ran == arr[i])
                        {
                            flag = -1;
                            break;
                        }
                        else
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        arr[j] = ran;
                        j++;
                    }
                }
                
            } while (j < 5);
            int a, b, c, d, e;
            a = arr[0]; b = arr[1]; c = arr[2]; d = arr[3]; e = arr[4];
            var pr = HomeHandler.addRandomProduct(a, b, c, d, e);
            return pr;
        }

        public static List<DetailedProduct> getAllProduct()
        {
            return ViewProductHandler.getProduct();
        }

        public static void deleteProduct(int id)
        {
            ViewProductHandler.deleteProduct(id);
        }

        public static int countProduct()
        {
            return HomeHandler.countProduct();
        }

        public static bool validateDelete(int id, out string errorMsg)
        {
            errorMsg = "";
            var p = ViewProductHandler.searchProductByID(id);
            var dt = ViewProductHandler.searchDetailTransactionByID(id);
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