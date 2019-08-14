using NUnit.Framework;
using System;

namespace BillingSample.Test
{
    public class BillingTests
    {
        [Test]
        public void It_Should_Return_True_If_The_Bill_Being_Sent_Is_Not_Null()
        {
            Bill bill = new Bill
            {
                Amount = 5000,
                DateSent = new DateTime(2019, 8, 14)
            };

            bool result = BillingController.SendBill(bill);

            Assert.IsTrue(result);
        }

        [Test]
        public void It_Should_Return_False_If_The_Bill_Being_Sent_Is_Null()
        {
            Bill bill = null;

            bool result = BillingController.SendBill(bill);

            Assert.IsTrue(!result);
        }

        [TestCase(17,8)]
        [TestCase(18,8)]
        public void Billing_Controller_Should_Return_False_If_A_Bill_Is_Being_Sent_On_A_Weekend(int day,int month)
        {
            Bill bill = new Bill
            {
                Amount = 5000,
                DateSent = new DateTime(2019, month, day)
            };

            bool result = BillingController.SendBill(bill);

            Assert.IsTrue(!result);
        }
    }
}
