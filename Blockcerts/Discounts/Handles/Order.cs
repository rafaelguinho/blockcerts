using Discounts.Models;
using System.Collections.Generic;

namespace Discounts.Handles
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
            Coupons = new List<Coupon>();
        }

        public double Total { get; private set; }

        public double Discount { get; private set; }

        public IList<Product> Products { get; private set; }

        public IList<Coupon> Coupons { get; private set; }

        public void AddCoupon(Coupon coupon)
        {
            Coupons.Add(coupon);
        }

        public void RemoveCoupons()
        {
            Coupons = new List<Coupon>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Total += product.Price;
        }

        public void AddDiscount(double discount)
        {
            Discount += discount;
        }
    }
}
