using System;

namespace RebateCalculator
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime LaunchDate { get; set; } = DateTime.Today;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}