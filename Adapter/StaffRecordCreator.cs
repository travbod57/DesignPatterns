using System;

namespace Adapter
{
    public static class StaffRecordCreator
    {
        public static void InsertIntoDatabase(ITarget target)
        {
            foreach (var employee in target.GetEmployees())
            {
                Console.WriteLine(employee);
            } 
        }
    }
}