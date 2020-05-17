using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class RegisterHandler
    {
        public static void addUser(string name, string email, string password, string gender)
        {
            UserRepository.RegisterUser(name, email, password, gender);
        }

        public static User SearchByEmail(string email)
        {
            return UserRepository.SearchByEmail(email);
        }
    }
}