using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class RegisterController
    {
        public static string doRegister(string Username, string Email, string DOB, string Gender, string Password, string ConfirmPassword, string Role)
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

            if (string.IsNullOrWhiteSpace(DOB))
            {
                return "Date of Birth cannot be empty.";
            }

            if (string.IsNullOrWhiteSpace(Gender))
            {
                return "Gender must be chosen and cannot be empty.";
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                return "Password cannot be empty.";
            }

            if (!Password.All(char.IsLetterOrDigit))
            {
                return "Password must be alphanumeric.";
            }

            if (string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                return "Confirmation password cannot be empty.";
            }

            if (ConfirmPassword != Password)
            {
                return "Password and confirmation password must be the same.";
            }

            return "Success";
        }
    }
}