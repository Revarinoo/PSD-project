using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ChangePasswordHandler
    {
        public static User checkOldPassword(int userID, string oldpass)
        {
            return UserRepository.checkOldPassword(userID, oldpass);
        }

        public static void ChangePassword(int userId, string oldpass, string newpass)
        {
           UserRepository.changePassword(userId, oldpass, newpass);
        }
    }
}