using GymMe.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class UpdateProfileController
    {
        public static string UpdateProfile(int id, string Username, string Email, DateTime DOB, string Gender, string Password, string ConfirmPassword, string Role)
        {
            if (string.IsNullOrEmpty(Username))
            {
                return "Username cannot be empty.";
            }

            if (Username.Length < 5 || Username.Length > 15)
            {
                return "Username length must be between 5 and 15 characters.";
            }

            if (!Username.All(char.IsLetterOrDigit))
            {
                return "Username can only contain alphabetic characters and numbers.";
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "Email cannot be empty.";
            }

            if (!Email.EndsWith(".com"))
            {
                return "Email must end with '.com'.";
            }

            if (DOB == default)
            {
                return "Date of Birth cannot be empty.";
            }

            if (string.IsNullOrWhiteSpace(Gender))
            {
                return "Gender must be chosen and cannot be empty.";
            }

            UserHandler.UpdateProfile(id, Username, Email, DOB, Gender, "Admin");
            return "Success";
        }
    }
}