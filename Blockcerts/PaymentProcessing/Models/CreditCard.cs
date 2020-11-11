using PaymentProcessing.Enums;
using PaymentProcessing.Interfaces;

namespace PaymentProcessing.Models
{
    public class CreditCard : IPaymentModel
    {
        public CreditCard(CardType cardType, string cardNumber)
        {
            CardType = cardType;
            CardNumber = cardNumber;
        }

        public CardType CardType { get; set; }

        public string CardNumber { get; set; }
    }
}
