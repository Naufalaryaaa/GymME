using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Factory
{
    public class UserFactory
    {
        public static MsUser Create(String username, String email, String DOB, String gender, String role, String password)
        {
            MsUser user = new MsUser()
            {
                UserName = username,
                UserEmail = email,
                UserDOB = DateTime.Parse(DOB),
                UserGender = gender,
                UserRole = role,
                UserPassword = password
            };
            return user;
        }
    }
}