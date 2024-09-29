using GymMe.Controller;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Page
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        private static DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Assuming the user ID is stored in session
                int userId = Convert.ToInt32(Session["UserID"]);
                LoadProfile(userId);
            }
        }

        private void LoadProfile(int userId)
        {
            var user = db.MsUsers.FirstOrDefault(u => u.UserID == userId);
            if (user != null)
            {
                UsernameTxt.Text = user.UserName;
                EmailTxt.Text = user.UserEmail;
                DOBTxt.Text = user.UserDOB.ToString("yyyy-MM-dd");
                GenderRbl.SelectedValue = user.UserGender;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserID"]);
            string username = UsernameTxt.Text;
            string email = EmailTxt.Text;
            DateTime dob = Convert.ToDateTime(DOBTxt.Text);
            string gender = GenderRbl.SelectedValue;

            string result = UpdateProfileController.UpdateProfile(userId, username, email, dob, gender, null, null, null);
            ErrorLbl.Text = result;
            

            if (result == "Success")
            {
                LoadProfile(userId);
            }

        }
    }
}