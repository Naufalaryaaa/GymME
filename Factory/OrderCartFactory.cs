using GymMe.Master;
using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Factory
{
    public class OrderCartFactory
    {
        public static MsCart createNewCart(int userId, int supplementId, int quantity)
        {        
            MsCart cart = new MsCart()
            {
                UserID = userId,
                SuplementID = supplementId,
                Quantity = quantity 
            };
            return cart;
        }
    }
}