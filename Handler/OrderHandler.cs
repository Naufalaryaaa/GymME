using GymMe.Factory;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Handler
{
    public class OrderHandler
    {
        public static String AddNewCart(int userId, int SupplementId, int quantity)
        {
            MsCart newcart = OrderCartFactory.createNewCart(userId, SupplementId, quantity);
            OrderRepository.AddToCart(newcart);

            return "Success";
        }

        public static void clearCart(int userId)
        {
            OrderRepository.clearCart(userId);
        }
    }
}