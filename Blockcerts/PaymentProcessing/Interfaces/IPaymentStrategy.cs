namespace PaymentProcessing.Interfaces
{
    public interface IPaymentStrategy<T> where T : IPaymentModel
    {
        void Pay(T model);
    }
}
