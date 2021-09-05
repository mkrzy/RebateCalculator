using System;

namespace RebateCalculator
{
    public abstract class Rebate
    {
        public string Name { get; set; }
        public double DiscountAmount { get; set; }
        public Product Product { get; set; }

        public Rebate(string name, double discountAmount, Product product)
        {
            this.Name = name;
            this.DiscountAmount = discountAmount;
            this.Product = product;
        }

        public double getRebatedPrice()
        {
            return Product.Price - DiscountAmount;
        }

        // Determines if the customer qualifies for the rebate - needed for complex rebates such as seasonal or quantity
        public abstract bool doesQualify(Order order);
    }
}