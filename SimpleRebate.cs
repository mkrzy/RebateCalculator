using System;

namespace RebateCalculator
{
    public class SimpleRebate : Rebate
    {
        public SimpleRebate(string name, double discountAmount, Product product) : base(name, discountAmount, product){}

        public override bool doesQualify(Order order)
        {
            return true;
        }
    }
}