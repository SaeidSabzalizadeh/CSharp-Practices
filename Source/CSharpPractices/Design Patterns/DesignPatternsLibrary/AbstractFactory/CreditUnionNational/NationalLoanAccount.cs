using DesignPatternsLibrary.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsLibrary.AbstractFactory.CreditUnionNational
{
    // ProductB2
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }
}
