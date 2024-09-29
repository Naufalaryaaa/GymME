using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Page
{
    public partial class ProfilePageCustomer : System.Web.UI.Page
    {
        private static DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    int userID = (int)Session["UserID"];
                    LoadUserProfile(userID);
                }
            }
        }

        private void LoadUserProfile(int userID)
        {
            var user = (from x in db.MsUsers where x.UserID == userID select x).FirstOrDefault();

            if (user != null)
            {
                UsernameLbl.Text = user.UserName;
                EmailLbl.Text = user.UserEmail;
                GenderLbl.Text = user.UserGender;
                DOBLbl.Text = user.UserDOB.ToString("dd-MM-yyyy");
            }
        }
    }
}