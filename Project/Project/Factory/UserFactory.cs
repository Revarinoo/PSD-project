using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class UserFactory
    {
        public static User CreateUser(String name, String email, String pass, String gender)
        {
            User usr = new User();
            usr.RoleID = 2;
            usr.Name = name;
            usr.Email = email;
            usr.Password = pass;
            usr.Gender = gender;
            usr.Status = "Active";
            return usr;
        }
    }
}