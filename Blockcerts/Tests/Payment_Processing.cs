using NUnit.Framework;
using PaymentProcessing.Enums;
using PaymentProcessing.Handles;
using PaymentProcessing.Interfaces;
using PaymentProcessing.Models;

namespace Tests
{
    [TestFixture]
    public class Payment_Processing
    {
        [Test]
        public void Pay_With_Credit_Card_Should_Not_Throw()
        {
            IPaymentStrategy<CreditCard> creditCardPayment = new CreditCardPayment();
            
            Assert.DoesNotThrow(() => creditCardPayment.Pay(new CreditCard(CardType.Visa, "4539867398424592")));
        }

        [Test]
        public void Pay_With_Cash_Should_Not_Throw()
        {
            IPaymentStrategy<Cash> cashPayment = new CashPayment();
            Assert.DoesNotThrow(() => cashPayment.Pay(new Cash()));
        }

        [Test]
        public void Pay_With_Paypal_Should_Not_Throw()
        {
            IPaymentStrategy<Paypal> payPalPayment = new PayPalPayment();
            Assert.DoesNotThrow(() => payPalPayment.Pay(new Paypal("lucasstrickland@teleworm.us")));
        }
    }
}
