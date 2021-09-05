using System;
using System.Collections.Generic;

namespace RebateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Products
            Product lumbersomeChair = new Product("Lumbersome Chair", 750);
            Product gratisfactionChair = new Product("Gratisfaction Chair", 1150);
            Product oneUpDesk = new Product("OneUp Desk", 1400);
            Product doubleUpDesk = new Product("DoubleUp Desk", 2100);
            Product docuKingPrinter = new Product("DocuKing Printer", 5300);

            List<Product> products = new List<Product>(){ lumbersomeChair, gratisfactionChair, oneUpDesk, doubleUpDesk, docuKingPrinter };

            // Customers
            Customer okea = new Customer("OKEA");
            Customer readyForce = new Customer("Ready Force");
            Customer spaceMake = new Customer("SpaceMake");
            Customer maketavia = new Customer("Maketavia Inc.");

            List<Customer> customers = new List<Customer>(){ okea, readyForce, spaceMake, maketavia };

            // Rebates
            Rebate lumbersomeRebate = new SimpleRebate("Lumbersome Rebate", 75, lumbersomeChair);
            Rebate gratisfactionRebate = new SimpleRebate("Gratisfaction Rebate", 105, gratisfactionChair);
            Rebate oneUpRebate = new SimpleRebate("OneUp Rebate", 70, oneUpDesk);
            Rebate doubleUpRebate = new SimpleRebate("DoubleUp Rebate", 165, doubleUpDesk);
            Rebate doubleUpPremiumRebate = new SimpleRebate("DoubleUp Premium Rebate", 330, doubleUpDesk);
            Rebate docuKingRebate = new SimpleRebate("DocuKing Rebate", 490, docuKingPrinter);

            List<Rebate> rebates = new List<Rebate>(){ lumbersomeRebate, gratisfactionRebate, oneUpRebate, doubleUpRebate, doubleUpPremiumRebate, docuKingRebate };

            // Rebate Agreements
            RebateAgreement okeaLumbersome = new RebateAgreement(okea, lumbersomeRebate);
            RebateAgreement okeaGratisfaction = new RebateAgreement(okea, gratisfactionRebate);
            RebateAgreement okeaDocuKing = new RebateAgreement(okea, docuKingRebate);
            RebateAgreement readyForceGratisfaction = new RebateAgreement(readyForce, gratisfactionRebate);
            RebateAgreement readyForceOneUp = new RebateAgreement(readyForce, oneUpRebate);
            RebateAgreement spaceMakeDoubleUp = new RebateAgreement(spaceMake, doubleUpRebate);
            RebateAgreement spaceMakeDocuKing = new RebateAgreement(spaceMake, docuKingRebate);

            List<RebateAgreement> rebateAgreements = new List<RebateAgreement>(){ 
                    okeaLumbersome, okeaGratisfaction, okeaDocuKing, readyForceGratisfaction, 
                    readyForceOneUp, spaceMakeDoubleUp, spaceMakeDocuKing 
                };

            // Add all rebates for most valued customer
            foreach(Rebate rebate in rebates){
                if(rebate.Name.Equals("DoubleUp Rebate"))
                {
                    continue;
                }
                rebateAgreements.Add(new RebateAgreement(maketavia, rebate));
            }

            // Display product prices
            Console.Clear();
            Console.WriteLine(String.Format("{0,-20} {1,-25} {2,15} {3,15}    {4,-20}", "Customer", "Product", "Standard Price", "Rebated Price", "Rebate Name"));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            foreach(RebateAgreement ra in rebateAgreements)
            {
                if(ra.Rebate.doesQualify(null)){
                    Console.WriteLine(String.Format("{0,-20} {1,-25} {2,15} {3,15}    {4,-25}", ra.Customer.Name, ra.Rebate.Product.Name, ra.Rebate.Product.Price, ra.Rebate.getRebatedPrice(), ra.Rebate.Name));
                }
            }
        }
    }
}
