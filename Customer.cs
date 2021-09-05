using System;

namespace RebateCalculator
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}