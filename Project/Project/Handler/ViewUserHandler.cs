using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handler
{
    public class ViewUserHandler
    {
        public static List<DetailedUser> getUser()
        {
            return UserRepository.getUser();
        }
    }
}