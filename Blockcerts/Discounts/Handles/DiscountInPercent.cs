using Discounts.Interfaces;
using System.Linq;

namespace Discounts.Handles
{
    public class DiscountInPercent : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Apply(Order order)
        {
            double discoutPercentage = 5;
            if (order.Products.Count() >= 3 && !order.Coupons.Any())
            {
                return order.Total * (discoutPercentage / 100);
            }
            else
            {
                return Next.Apply(order);
            }
        }
    }
}
