using System;
using System.Diagnostics;
using System.Linq;

namespace MultiThreading.PLINQ
{
    public class SimplePLINQ
    {
        public static void Run()
        {
            var list = Enumerable.Range(1, 10000000);

            Console.WriteLine();
            Console.WriteLine("Without PLINQ:");
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var primeNumbers1 = list.Where(IsPrime);
            Console.WriteLine("{0} prime numbers found", primeNumbers1.Count());
            stopwatch.Stop();
            Console.WriteLine("Time taken" + stopwatch.ElapsedMilliseconds);


            Console.WriteLine();
            Console.WriteLine("With PLINQ:");

            stopwatch.Start();
            var primeNumbers2 = list.AsParallel().Where(IsPrime);
            Console.WriteLine("{0} prime numbers found", primeNumbers2.Count());
            stopwatch.Stop();
            Console.WriteLine("Time taken" + stopwatch.ElapsedMilliseconds);


        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
