using PaymentProcessing.Interfaces;

namespace PaymentProcessing.Models
{
    public class Paypal : IPaymentModel
    {
        public Paypal(string email)
        {
            Email = email;
        }

        public string Email { get; set; }
    }
}
