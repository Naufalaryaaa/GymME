using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace GymMe.Repository
{
    public class TransactionHeaderRepository
    {
        private static DatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionHeader> GetTransactionHeaders()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        public static void UpdateStatus(int transactionId, string status)
        {
            var transaction = (from x in db.TransactionHeaders where x.TransactionID == transactionId select x).FirstOrDefault();
            if (transaction != null)
            {
                transaction.Status = status;
                db.SaveChanges();
            }
        }

        public static List<TransactionHeader> GetTransactionHeadersCustomer(int userId)
        {
            return (from x in db.TransactionHeaders where x.UserID == userId select x).ToList();
        }

    }
}