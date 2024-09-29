using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class UserRepository
    {
        private static DatabaseEntities db = DatabaseSingleton.GetInstance();
        public static MsUser GetUser(string username, string password)
        {
            return (from x in db.MsUsers where x.UserName.Equals(username) && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public static List<MsUser> Customer()
        {
            return (from x in db.MsUsers where x.UserRole.Equals("Customer") select x).ToList();
        }

        public static MsUser GetUserById(int id)
        {
            return db.MsUsers.FirstOrDefault(x => x.UserID == id);
        }

        public static MsUser GetUserByEmail(string email)
        {
            return (from x in db.MsUsers where x.UserEmail == email select x).FirstOrDefault();
        }

        public static void AddUser(MsUser user)
        {
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public static void UpdateProfile(int id, string Username, string Email, DateTime DOB, string Gender, string Role)
        {
            var user = db.MsUsers.FirstOrDefault(x => x.UserID == id);
            if (user != null)
            {
                user.UserName = Username;
                user.UserEmail = Email;
                user.UserDOB = DOB;
                user.UserGender = Gender;
                user.UserRole = Role;
                db.SaveChanges();
            }
        }
    }
}