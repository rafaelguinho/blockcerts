using PaymentProcessing.Interfaces;
using PaymentProcessing.Models;
using System;

namespace PaymentProcessing.Handles
{
    public class CashPayment : IPaymentStrategy<Cash>
    {
        public void Pay(Cash cash)
        {
            Save(cash);
        }

        private void Save(Cash cash)
        {
            Console.WriteLine("Saved cash payment");
        }
    }
}
