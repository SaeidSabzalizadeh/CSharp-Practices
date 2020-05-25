using DesignPatternsLibrary.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsLibrary.AbstractFactory.CreditUnionCiti
{
    // Concrete ProductA1
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Console.WriteLine("Returned Citi Savings Account");
        }
    }
}
