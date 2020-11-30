using System;
using System.Collections.Generic;

namespace Adapter
{
    public class BillingSystemToEmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem _thirdPartyBillingSystem;

        public BillingSystemToEmployeeAdapter(ThirdPartyBillingSystem thirdPartyBillingSystem)
        {
            _thirdPartyBillingSystem = thirdPartyBillingSystem;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            string[,] billingSystemEmployees = _thirdPartyBillingSystem.GetEmployees();

            for (int i = 0; i < billingSystemEmployees.GetLength(0); i++)
            {
                for (int j = 0; j < billingSystemEmployees.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = billingSystemEmployees[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = billingSystemEmployees[i, j];
                    }
                    else if (j == 2)
                    {
                        Designation = billingSystemEmployees[i, j];
                    }
                    else
                    {
                        Salary = billingSystemEmployees[i, j];
                    }
                }

                employees.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }

            return employees;
        }
    }
}