using GymMe.Controller;
using GymMe.Handler;
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
    public partial class ManageSupplementPage : System.Web.UI.Page
    {
        private static DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var supplements = MsSupplementRepository.GetSupplement();

            GridView.DataSource = supplements;
            GridView.DataBind();

        }

        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow Row = GridView.Rows[e.NewEditIndex];
            String ID = Row.Cells[0].Text.ToString();

            Response.Redirect("/Page/UpdateSupplementPage.aspx?ID=" +ID);
        }

        protected void GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow Row = GridView.Rows[e.RowIndex];
            int id = Convert.ToInt32(Row.Cells[0].Text.ToString());

            SupplementController.DeleteSupplement(id);
            GridView.DataBind();

            Response.Redirect("/Page/ManageSupplementPage.aspx");
        }
    }
}