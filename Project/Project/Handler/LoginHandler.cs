using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class LoginHandler
    {
        public static Boolean CheckLogin(string email, string password)
        {
            User usr = UserRepository.doLogin(email, password);
            return (usr == null) ? false : true;
        }

        public static Boolean CheckStatus(int id)
        {
            User usr = UserRepository.SearchByID(id);
            return (usr.Status.Equals("Active")) ? true : false;
        }

        public static User SearchByEmail(string email)
        {
            return UserRepository.SearchByEmail(email);
        }

    }
}