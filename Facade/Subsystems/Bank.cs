using System;

namespace Facade.Subsystems
{
    /// <summary>
    /// A sub system class
    /// </summary>
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, decimal amount)
        {
            Console.WriteLine($"Check bank for { customer.Name } for amount { amount.ToString("C") }");
            return true;
        }
    }
}