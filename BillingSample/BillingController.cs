using System;

namespace BillingSample
{
    public static class BillingController
    {
        public static bool SendBill(Bill bill)
        {
            if (bill == null)
                return false;

            return !(bill.DateSent.DayOfWeek == DayOfWeek.Saturday ||
                 bill.DateSent.DayOfWeek == DayOfWeek.Sunday);
        }
    }
}
