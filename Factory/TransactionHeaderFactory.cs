using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int UserID)
        {
            TransactionHeader transactionHeader = new TransactionHeader()
            {
                UserID = UserID,
                TransactionDate = DateTime.Now,
                Status = "Unhandled"
            };
            return transactionHeader;
        }
    }
}