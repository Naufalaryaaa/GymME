using System;
using GymMe.Handler;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class LoginController
    {
        public static String CheckUsername(String username)
        {
            String response = "";
            if (username.Equals("")) response = "Username cannot be empty.";
            return response;
        }
        public static String CheckPassword(String password)
        {
            String response = "";
            if (password.Equals("")) response = "Password cannot be empty.";
            return response;
        }
        public static String doLogin(String username, String password)
        {
            String response = CheckUsername(username);
            if (response.Equals("")) response = CheckPassword(password);
            if (response.Equals("")) response = UserHandler.doLogin(username, password);
            return response;
        }
    }
}