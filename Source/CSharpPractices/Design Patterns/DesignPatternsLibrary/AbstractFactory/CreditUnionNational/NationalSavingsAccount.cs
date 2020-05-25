using DesignPatternsLibrary.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsLibrary.AbstractFactory.CreditUnionNational
{
    // ProductA2
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Savings Account");
        }
    }
}
