using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class UpdateProfileHandler
    {
        public static void updateProfile(int userID, string name, string email, string gender)
        {
            UserRepository.updateProfile(userID, name, email, gender);
        }

        public static User SearchByEmail(string email)
        {
            return UserRepository.SearchByEmail(email);
        }
    }
}