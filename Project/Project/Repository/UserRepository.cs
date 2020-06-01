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

        public static List<DetailedUser> getUser()
        {
            var user = (from x in dbEntity.Users join y in dbEntity.Roles
                        on x.RoleID equals y.RoleID
                        select new DetailedUser()
                        {
                            UserID = x.UserID,
                            Name = x.Name,
                            Role = y.RoleName,
                            Status = x.Status
                        });
            return user.ToList();
            //var view = (from x in dbEntity.Users
            //            select new User()
            //            {
            //                UserID = x.UserID,
            //                Name = x.Name,
            //                RoleID = x.RoleID,
            //                Status = x.Status
            //            });

            //return view.ToList();
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

        public static User checkOldPassword(int id, string oldpass)
        {
            return (from x in dbEntity.Users
                    where x.UserID == id && x.Password == oldpass
                    select x).FirstOrDefault();
        }

        public static User doLogin(string email, string password)
        {
            return (from x in dbEntity.Users
                    where x.Email == email && x.Password == password
                    select x).FirstOrDefault();
        }

        public static void changePassword(int userID, string oldpass, string newpass)
        {
            User usr = (User)dbEntity.Users.Where(u => u.UserID == userID && u.Password == oldpass).FirstOrDefault();
            usr.Password = newpass;
            dbEntity.SaveChanges();
        }

        public static void changeStatus(int id)
        {
            User usr = (User)dbEntity.Users.Where(u => u.UserID == id).FirstOrDefault();
            if(usr.Status == "active")
            {
                usr.Status = "block";
                dbEntity.SaveChanges();
            }
            else if(usr.Status == "block")
            {
                usr.Status = "active";
                dbEntity.SaveChanges();
            }
        }

        public static void updateProfile(int userID, string name, string email, string gender)
        {
            User usr = (User)dbEntity.Users.Where(u => u.UserID == userID).FirstOrDefault();
            usr.Name = name;
            usr.Email = email;
            usr.Gender = gender;
            dbEntity.SaveChanges();
        }
    }
}