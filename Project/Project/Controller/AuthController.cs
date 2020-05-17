using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class AuthController
    {
        public static bool doLogin(string email, string pass, out string errorMsg)
        {
            User usr = LoginHandler.SearchByEmail(email);
            errorMsg = "";
            if (email == "" || pass == "")
            {
                errorMsg = "Email or password is empty!";
                return false;
            }
            else
            {
                bool success = LoginHandler.CheckLogin(email, pass);
                if (!success)
                {
                    errorMsg = "Data invalid";
                    return false;
                }
                else
                {
                    if (!LoginHandler.CheckStatus(usr.UserID))
                    {
                        errorMsg = "User Blocked!";
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        public static User SearchByEmail(string email)
        {
            return LoginHandler.SearchByEmail(email);
        }
    }
}