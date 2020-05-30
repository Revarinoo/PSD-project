using Project.Factory;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class UserHandler
    {
        public static List<User> getAllUser()
        {
            return UserRepository.getAllUser();
        }
    }
}