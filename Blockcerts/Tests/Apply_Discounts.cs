using Discounts.Handles;
using Discounts.Models;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Apply_Discounts
    {
        private Order order;

        [SetUp]
        public void SetUp()
        {
            order = new Order();
            order.AddProduct(new Product("13-inch MacBook Air", 1249.99));
            order.AddProduct(new Product("AirPods Pro", 249));
            order.AddProduct(new Product("Mac Pro", 6499.99));
        }

        [Test]
        public void Apply_10_Percent_Coupon_Discount_799_898()
        {
            order.AddCoupon(new Coupon(10));

            double discount = new DiscountCalculator().ApplyDiscount(order);
            order.AddDiscount(discount);

            Assert.AreEqual(799.898, discount);
        }

        [Test]
        public void If_Has_3_Products_Or_More_Apply_5_Percent_Discount_399_949()
        {
            order.RemoveCoupons();

            double discount = new DiscountCalculator().ApplyDiscount(order);
            order.AddDiscount(discount);

            Assert.AreEqual(399.949, discount);
        }
    }
}
