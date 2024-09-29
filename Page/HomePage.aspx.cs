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
    public partial class HomePage : System.Web.UI.Page
    {
        private static DatabaseEntities db = new DatabaseEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var user = UserRepository.Customer();

            GridView1.DataSource = user;
            GridView1.DataBind();

        }
    }
}