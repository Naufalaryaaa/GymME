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
    public partial class OrderQueuePage : System.Web.UI.Page
    {
        private static DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTransactions();
            }
        }

        private void LoadTransactions()
        {
            var transactions = TransactionHeaderRepository.GetTransactionHeaders();
            GridView.DataSource = transactions;
            GridView.DataBind();
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "UpdateStatus")
            {
                int transactionId = Convert.ToInt32(e.CommandArgument);
                TransactionHeaderController.UpdateTransactionStatus(transactionId, "Handled");
                LoadTransactions();
            }
        }
    }
}