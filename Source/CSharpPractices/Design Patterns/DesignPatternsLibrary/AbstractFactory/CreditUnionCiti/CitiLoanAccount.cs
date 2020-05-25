using DesignPatternsLibrary.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsLibrary.AbstractFactory.CreditUnionCiti
{
    // Concrete ProductB1
    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("Returned Citi Loan Account");
        }
    }
}
