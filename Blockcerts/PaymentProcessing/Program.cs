using PaymentProcessing.Enums;
using PaymentProcessing.Handles;
using PaymentProcessing.Interfaces;
using PaymentProcessing.Models;

namespace PaymentProcessing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPaymentStrategy<Cash> cashPayment = new CashPayment();
            cashPayment.Pay(new Cash());

            IPaymentStrategy<CreditCard> creditCardPayment = new CreditCardPayment();
            creditCardPayment.Pay(new CreditCard(CardType.Visa, "4539867398424592"));

            IPaymentStrategy<Paypal> payPalPayment = new PayPalPayment();
            payPalPayment.Pay(new Paypal("lucasstrickland@teleworm.us"));
        }
    }
}
