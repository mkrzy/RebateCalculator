using System;

namespace RebateCalculator
{
    public class SeasonalRebate : Rebate
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SeasonalRebate(string name, double discountAmount, Product product, DateTime startDate, DateTime endDate) : base(name, discountAmount, product)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public override bool doesQualify(Order order)
        {
            if (order.Date >= this.StartDate && order.Date <= this.EndDate)
            {
                return true;
            }
            return false;
        }
    }
}