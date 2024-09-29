using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class OrderRepository
    {
        private static DatabaseEntities db = DatabaseSingleton.GetInstance();
        public static void AddToCart(MsCart cart)
        {
            db.MsCarts.Add(cart);
            db.SaveChanges();
        }

        public static List<MsCart> CallCart(int userId)
        {
            return (from cart in db.MsCarts where cart.UserID == userId select cart).ToList();
        }

       public static void clearCart(int userId)
        {
            DatabaseEntities db = DatabaseSingleton.GetInstance();
            List<MsCart> userCart = db.MsCarts.Where(cart =>  cart.UserID == userId).ToList();
            db.MsCarts.RemoveRange(userCart);
            db.SaveChanges();
        }

        public static List<TransactionHeader> CallHistory(int userId)
        {
            return (from history in db.TransactionHeaders where history.UserID == userId select history).ToList();
        }
    }
}