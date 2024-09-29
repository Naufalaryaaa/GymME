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
    public partial class UpdateSupplement : System.Web.UI.Page
    {
        public static DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String id = Request["id"];
                int supplementId;
                if (int.TryParse(id, out supplementId))
                {
                    MsSupplement supplement = db.MsSupplements.Find(supplementId);
                    if (supplement != null)
                    {
                        NameTxt.Text = supplement.SupplementName;
                        ExpiryDateTxt.Text = supplement.SupplementExpiryDate.ToString("yyyy-MM-dd");
                        PriceTxt.Text = supplement.SupplementPrice.ToString();
                        TypeTxt.Text = supplement.SupplementTypeID.ToString();
                    }
                }
            }
        }
        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Page/ManageSupplementPage.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            String id = Request["id"];
            int supplementId;
            if (int.TryParse(id, out supplementId))
            {
                String name = NameTxt.Text;
                String expiry = ExpiryDateTxt.Text;
                int price;
                int typeId;
                if (int.TryParse(PriceTxt.Text, out price) && int.TryParse(TypeTxt.Text, out typeId))
                {
                    String result = SupplementController.UpdateSupplement(supplementId, name, expiry, price, typeId);
                    if (result.Equals("Success"))
                    {
                        Response.Redirect("/Page/ManageSupplementPage.aspx");
                    }
                    else
                    {
                        ErrorLbl.Text = result;
                    }
                }
                else
                {
                    ErrorLbl.Text = "Price and Type ID must be numeric.";
                }
            }
        }

    }
}