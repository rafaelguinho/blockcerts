using Discounts.Interfaces;

namespace Discounts.Handles
{
    public class NoDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Apply(Order order)
        {
            return 0;
        }
    }
}
