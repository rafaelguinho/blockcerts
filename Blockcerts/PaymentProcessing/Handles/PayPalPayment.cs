using PaymentProcessing.Interfaces;
using PaymentProcessing.Models;
using System;

namespace PaymentProcessing.Handles
{
    public class PayPalPayment : IPaymentStrategy<Paypal>
    {
        public void Pay(Paypal model)
        {
            Console.WriteLine("Paypal payment");
        }
    }
}
