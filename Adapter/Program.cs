using System;

namespace Adapter
{
    class Program
    {
        /*
         * The Adapter Pattern is a software design pattern that attempts to reconcile the differences between two otherwise-incompatible interfaces. 
         * This pattern is especially useful when attempting to adapt to an interface that cannot be refactored.
         * 
         * Useful for integrating legacy systems with new or thrid party APIs
         * 
         * Closely related to the Facade pattern
         * 
         */

        static void Main(string[] args)
        {
            // Adaptee
            ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

            // Pass Adaptee to Adapter. Might have many adpaters if employee information comes from many sources
            ITarget target = new BillingSystemToEmployeeAdapter(thirdPartyBillingSystem);

            // employees from thrid party system are now in a form compatible with current system
            StaffRecordCreator.InsertIntoDatabase(target);

            Console.ReadLine();
        }
    }
}