using System;

namespace Facade.Subsystems
{
    /// <summary>
    /// A sub system class
    /// </summary>
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine($"Check loans for { customer.Name }");
            return true;
        }
    }
}