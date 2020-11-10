using Discounts.Interfaces;

namespace Discounts.Handles
{
    public class DiscountCalculator
    {
        public double ApplyDiscount(Order order)
        {
            IDiscount d1 = new DiscountInPercent();
            IDiscount d2 = new DiscontWithCoupons();
            IDiscount d3 = new NoDiscount();

            d1.Next = d2;
            d2.Next = d3;

            return d1.Apply(order);
        }
    }
}
