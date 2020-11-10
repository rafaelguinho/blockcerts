using Discounts.Handles;
using Discounts.Models;
using System;

namespace Discounts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order();
            order.AddProduct(new Product("", 12.9));
            order.AddProduct(new Product("", 12.9));
            order.AddProduct(new Product("", 12.9));

            order.AddCoupon(new Coupon(10));

            double discount = new DiscountCalculator().ApplyDiscount(order);
            order.AddDiscount(discount);

            Console.WriteLine(order.Discount);
        }
    }
}
