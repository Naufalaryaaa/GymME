using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Repository
{
    public class MsSupplementRepository
    {
        private static DatabaseEntities db = DatabaseSingleton.GetInstance();
        public static List<MsSupplement> GetSupplement()
        {
            return (from x in db.MsSupplements select x).ToList();
        }

        public static void DeleteSupplement(int SupplementID)
        {
            MsSupplement msSupplement = (from x in db.MsSupplements where x.SupplementID == SupplementID select x).FirstOrDefault();
            if(msSupplement != null)
            {
                db.MsSupplements.Remove(msSupplement);
                db.SaveChanges();
            }
        }

        public static void UpdateSupplement(int SupplementID, String SupplementName, DateTime ExpiryDate, int Price, int TypeID)
        {
            MsSupplement msSupplement = (from x in db.MsSupplements where x.SupplementID == SupplementID select x).FirstOrDefault();
            msSupplement.SupplementName = SupplementName;
            msSupplement.SupplementExpiryDate = ExpiryDate;
            msSupplement.SupplementPrice = Price;
            msSupplement.SupplementTypeID = TypeID;
            db.SaveChanges();
        }

    }
}