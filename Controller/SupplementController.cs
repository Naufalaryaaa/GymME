using GymMe.Handler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class SupplementController
    {
        public static String UpdateSupplement(int id, String supplementName, String supplementExpiryDate, int price, int type)
        {
            if (string.IsNullOrEmpty(supplementName))
            {
                return "Supplement Name cannot be empty.";
            }

            if (!supplementName.Contains("Supplement"))
            {
                return "Supplement Name must contain 'Supplement'.";
            }

            if (string.IsNullOrEmpty(supplementExpiryDate))
            {
                return "Supplement Expiry Date cannot be empty.";
            }

            DateTime expiryDate;
            if (!DateTime.TryParse(supplementExpiryDate, out expiryDate) || expiryDate < DateTime.Now)
            {
                return "Expiry date must be a valid date and greater than today's date.";
            }

            if (price < 3000)
            {
                return "Supplement price must be at least 3000.";
            }

            if (type <= 0)
            {
                return "Supplement Type ID cannot be empty.";
            }

            SupplementHandler.UpdateSupplement(id, supplementName, expiryDate, price, type);
            return "Success";
        }

        public static void DeleteSupplement(int id)
        {
            SupplementHandler.DeleteSupplement(id);
        }

    }
}