using GymMe.Controller;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Page
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private static DatabaseEntities db = new DatabaseEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            String username = UsernameTxt.Text;
            String password = PasswordTxt.Text;
            bool Remember = RememberCb.Checked;

            ErrorLbl.Text = LoginController.doLogin(username, password);
            ErrorLbl.ForeColor = System.Drawing.Color.Red;

            var user = (from x in db.MsUsers where x.UserName.Equals(username) && x.UserPassword.Equals(password) select x).FirstOrDefault();
            if (user != null)
            {
                Session["UserID"] = user.UserID;

                if (user.UserRole == "Admin")
                {
                    Response.Redirect("/Page/HomePage.aspx");
                }
                else
                {
                    Response.Redirect("/Page/HomePageCustomer.aspx");
                }

                if (Remember)
                {
                    HttpCookie cookie = new HttpCookie("user-cookie");
                    cookie.Value = user.UserID.ToString();
                    if (Remember)
                    {
                        cookie.Expires = DateTime.Now.AddHours(1);
                    }
                    else
                    {
                        cookie.Expires = DateTime.MinValue;
                    }
                    Response.Cookies.Add(cookie);
                }
            }
        }

        protected void dont_have_accountLb_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Page/RegisterPage.aspx");
        }
    }
}