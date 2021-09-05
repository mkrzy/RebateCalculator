using System;

namespace RebateCalculator
{
    public class RebateAgreement
    {
        public Customer Customer { get; set; }
        public Rebate Rebate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public RebateAgreement(Customer customer, Rebate rebate)
        {
            this.Customer = customer;
            this.Rebate = rebate;
        }

        public RebateAgreement(Customer customer, Rebate rebate, DateTime startDate, DateTime endDate)
        {
            this.Customer = customer;
            this.Rebate = rebate;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}