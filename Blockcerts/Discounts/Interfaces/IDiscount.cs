using Discounts.Handles;

namespace Discounts.Interfaces
{
    public interface IDiscount
    {
        double Apply(Order order);

        IDiscount Next { get; set; }
    }
}
