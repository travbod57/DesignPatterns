using Facade.Subsystems;
using System;

namespace Facade
{
    /// <summary>
    /// The FACADE class
    /// </summary>
    public class MortgageChecker
    {
        private readonly Bank _bank;
        private readonly Loan _loan;
        private readonly Credit _credit;

        public MortgageChecker(Bank bank, Loan loan, Credit credit)
        {
            _bank = bank;
            _loan = loan;
            _credit = credit;
        }

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan", customer.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}