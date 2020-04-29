using System;
using System.Linq;

namespace MultiThreading.PLINQ
{
    public class ConcurrencyBag
    {

        static System.Collections.Concurrent.ConcurrentBag<int> concurrentBag = new System.Collections.Concurrent.ConcurrentBag<int>();

        public static void Run()
        {
            var list = Enumerable.Range(2000, 5000);

            //var orderedQuery = list.AsParallel().AsOrdered().Where(x => x % 25 == 0); // or makeit order like this
            var query = list.AsParallel().Where(x => x % 25 == 0);
            query.ForAll(Adding);

            Console.WriteLine($"Total elements: {concurrentBag.Count}");
        }

        private static void Adding(int queryResult)
        {
            Console.WriteLine($"adding {DateTime.Now.ToString("mm:ss.fffff")}");
            concurrentBag.Add(queryResult);
        }
    }
}
