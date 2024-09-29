using GymMe.Controller;
using GymMe.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Page
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string email = EmailTxt.Text;
            string gender = GenderRbl.SelectedItem?.Text;
            string password = PasswordTxt.Text;
            string confirmPassword = ConfirmPasswordTxt.Text;
            string dob = DOBTxt.Text;

            string result = RegisterController.doRegister(username, email, dob, gender, password, confirmPassword, "Customer");

            if (result.Equals("Success"))
            {
                string registerResult = UserHandler.doRegister(username, email, dob, gender, password, confirmPassword, "Customer");

                if (registerResult.Equals("Success"))
                {
                    Response.Redirect("/Page/LoginPage.aspx");
                }
                else
                {
                    ErrorLbl.Text = registerResult;
                }
            }
            else
            {
                ErrorLbl.Text = result;
            }
        }
    }
}