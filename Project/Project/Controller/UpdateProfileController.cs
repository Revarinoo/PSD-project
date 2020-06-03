using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class UpdateProfileController
    {
        public static bool validateUpdate(int userID, string name, string email, string gender, out string errorMsg)
        {
            User usr = UpdateProfileHandler.SearchByEmail(email);
            errorMsg= "";
            if (usr != null)
            {
                errorMsg = "Email already exists!";
                return false;
            }
            else if(email == "")
            {
                errorMsg = "Data must be filled!";
                return false;
            }
            else if (!email.EndsWith(".com"))
            {
                errorMsg = "Email must be end with '.com'";
                return false;
            }
            else if (!email.Contains("@"))
            {
                errorMsg = "Email must be contain '@' ";
                return false;
            }
            else if(name == "")
            {
                errorMsg = "Data must be filled!";
                return false;
            }else if(gender == "")
            {
                errorMsg = "Gender must be chosen";
                return false;
            }
            else
            {
                UpdateProfileHandler.updateProfile(userID, name, email, gender);
                return true;
            }
        
        }
    }
}