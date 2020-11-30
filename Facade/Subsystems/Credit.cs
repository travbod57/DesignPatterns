using System;

namespace Facade.Subsystems
{
    /// <summary>
    /// A sub system class
    /// </summary>
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine($"Check credit for { customer.Name }");
            return true;
        }
    }
}