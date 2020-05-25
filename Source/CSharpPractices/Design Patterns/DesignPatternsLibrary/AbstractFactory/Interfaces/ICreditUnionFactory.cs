﻿namespace DesignPatternsLibrary.AbstractFactory.Interfaces
{
    // Abstract Factory
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }
}
