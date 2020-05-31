using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class ViewUserController
    {
        public static List<DetailedUser> getUser()
        {
            return ViewUserHandler.getUser();
        }
    }
}