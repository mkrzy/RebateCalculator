using System;
using System.Collections.Generic;

namespace RebateCalculator
{
    /**
    * The order class would be used to calculate various types of rebates
    * For example:
    * - Seasonal Rebate: Is the order date within the rebate date?
    * - Value Rebate: Is the total value of the order above a certain threshold?
    * - Volume Rebate: Is the quantity of a product above a certain threshold?
    */
    public class Order
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Dictionary<Product, int> ProductQuantities { get; set; }
    }
}