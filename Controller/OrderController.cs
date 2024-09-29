using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class OrderController
    {
        public static String VerCart(int userId, int supplementId, int quantity)
        {
            if(quantity == 0)
            {
                return "Quantity Must bigger than 0";
            }
            
            return "Success";
        }
    }
}