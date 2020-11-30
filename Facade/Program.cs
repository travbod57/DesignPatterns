using Facade.Subsystems;
using System;

namespace Facade
{
    class Program
    {
        /*
         * Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use. 
         * 
         */

        static void Main(string[] args)
        {
            // Facade
            MortgageChecker mortgageChecker = new MortgageChecker(new Bank(), new Loan(), new Credit());

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgageChecker.IsEligible(customer, 125000);

            Console.WriteLine($"{ customer.Name } has been { (eligible ? "Approved" : "Rejected") }");

            Console.ReadLine();
        }
    }
}
