using Project.Factory;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class UserRepository
    {
        static TokobediaEntities dbEntity = new TokobediaEntities();

        public static List<User> getAllUser()
        {
            return dbEntity.Users.ToList();
        }

        public static void RegisterUser(String name, String email, String pass, String gender)
        {
            User usr = UserFactory.CreateUser(name,email,pass,gender);
            dbEntity.Users.Add(usr);
            dbEntity.SaveChanges();
        }

        public static User SearchByEmail(String email)
        {
            return (from x in dbEntity.Users
                    where x.Email == email
                    select x).FirstOrDefault();
        }

        public static User SearchByID(int id)
        {
            return (from x in dbEntity.Users
                    where x.UserID == id
                    select x).FirstOrDefault();
        }

        public static User doLogin(string email, string password)
        {
            return (from x in dbEntity.Users
                    where x.Email == email && x.Password == password
                    select x).FirstOrDefault();
        }

        
    }
}