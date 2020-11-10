namespace Discounts.Models
{
    public class Coupon
    {
        public Coupon(double discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        public double DiscountPercentage { get; set; }
    }
}
