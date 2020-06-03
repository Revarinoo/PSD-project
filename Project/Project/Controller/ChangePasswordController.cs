﻿using Project.Handler;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ChangePasswordController
    {
        public static bool validatePassword(int userID, string oldpass, string newpass, string confpass, out string errorMsg)
        {
            User pass = ChangePasswordHandler.checkOldPassword(userID, oldpass);
            errorMsg = "";
            if(pass == null || pass.Password != oldpass)
            {
                errorMsg = "Old Password not match";
                return false;
            }
            else if(newpass == "")
            {
                errorMsg = "Data must be filled!";
                return false;
            }
            else if(oldpass == newpass)
            {
                errorMsg = "New password must be different from old password";
                return false;
            }
            else if(newpass != confpass)
            {
                errorMsg = "Confirmation password must be same with New Password!";
                return false;
            }
            else
            {
                //ChangePasswordHandler.ChangePassword(userID, oldpass, newpass);
                return true;
            }
        }

        public static void changePassword(int id, string oldpass, string newpass)
        {
            ChangePasswordHandler.ChangePassword(id, oldpass, newpass); 
        }
    }
}