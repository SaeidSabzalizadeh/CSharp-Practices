using System;

namespace DesignPatternsLibrary.Singleton
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            //var policy = new Policy();
            var insuredName = Policy.Instance.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
