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
    public partial class OrderPage : System.Web.UI.Page
    {
        DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var supplements = MsSupplementRepository.GetSupplement();
            GridView1.DataSource = supplements;
            GridView1.DataBind();

            
            int userID = Convert.ToInt32(Session["UserID"]);
            List<MsCart> userCarts = OrderRepository.CallCart(userID);    
            GridView2.DataSource = userCarts;
            GridView2.DataBind();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplementTypeNametxt.Text = GridView1.SelectedRow.Cells[0].Text;
            supplementIdtxt.Text = GridView1.SelectedRow.Cells[1].Text;
            supplementNametxt.Text = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            String userID = (Session["UserID"]).ToString();
            int userId = int.Parse(userID);

            OrderHandler.clearCart(userId);
            Response.Redirect("/Page/OrderPage.aspx");
        }

        protected void CheckOutBtn_Click(object sender, EventArgs e)
        {

        }

        protected void AddCartBtn_Click(object sender, EventArgs e)
        {
            GridViewRow selectedRow = GridView1.SelectedRow;

            String userID = (Session["UserID"]).ToString();
            int userId = int.Parse(userID);

            String supplementIdStr = supplementIdtxt.Text;
            int supplementId = int.Parse(supplementIdStr);

            String quantityStr = quantitytxtkedua.Text;
            int quantity = int.Parse(quantityStr);

            String result = OrderController.VerCart(userId, supplementId, quantity);

            if (result.Equals("Success"))
            {
                String AddCart = OrderHandler.AddNewCart(userId, supplementId, quantity);


                if (AddCart.Equals("Success"))
                {
                    ErrorLbl.Text = userID.ToString();
                }
                else
                {
                    ErrorLbl.Text = "Please Try Again";
                }
            }
            else
            {
                ErrorLbl.Text = "Error Occur Please Try Again";
            }

            Response.Redirect("/Page/OrderPage.aspx");

        }
    }
}



