using Discounts.Interfaces;
using System.Linq;

namespace Discounts.Handles
{
    public class DiscontWithCoupons : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Apply(Order order)
        {
            if (order.Coupons.Any())
            {
                double discoutPercentages = order.Coupons.Sum(c => c.DiscountPercentage);
                return order.Total * (discoutPercentages / 100);
            }
            else
            {
                return Next.Apply(order);
            }
        }
    }
}
