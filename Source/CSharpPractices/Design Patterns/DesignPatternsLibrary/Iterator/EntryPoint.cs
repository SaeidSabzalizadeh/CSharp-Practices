using DesignPatternsLibrary.Iterator.Aggregate;
using DesignPatternsLibrary.Iterator.Iterator;
using System;

namespace DesignPatternsLibrary.Iterator
{
    public class EntryPoint
    {
      public  static void Main(string[] args)
        {
            INewspaper nyp = new NYPaper();
            INewspaper lap = new LAPaper();

            IIterator nypIterator = nyp.CreateIterator();
            IIterator lapIterator = lap.CreateIterator();

            Console.WriteLine("--------   NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------   LAPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

       private static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
