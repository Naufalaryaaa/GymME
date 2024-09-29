using GymMe.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Controller
{
    public class TransactionHeaderController
    {
        public static void UpdateTransactionStatus(int transactionId, string status)
        {
            TransactionHeaderHandler.UpdateStatus(transactionId, status);
        }
    }
}