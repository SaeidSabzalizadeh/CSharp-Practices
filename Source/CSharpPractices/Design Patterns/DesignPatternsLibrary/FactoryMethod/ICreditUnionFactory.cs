namespace DesignPatternsLibrary.FactoryMethod
{
    // Creator
    interface ICreditUnionFactory
    {
        SavingsAccount GetSavingsAccount(string acctNo);
    }
}
