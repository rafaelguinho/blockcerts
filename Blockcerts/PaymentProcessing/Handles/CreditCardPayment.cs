using PaymentProcessing.Interfaces;
using PaymentProcessing.Models;
using System;

namespace PaymentProcessing.Handles
{
    public class CreditCardPayment : IPaymentStrategy<CreditCard>
    {
        public void Pay(CreditCard model)
        {
            Console.WriteLine("Credit Card payment");
        }
    }
}
