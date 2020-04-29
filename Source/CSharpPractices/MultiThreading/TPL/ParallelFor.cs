using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MultiThreading.TPL
{
    public class ParallelFor
    {
        public static void Run()
        {

            Console.WriteLine("Simple For:");
            Console.WriteLine();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            stopwatch.Stop();

            Console.WriteLine("Time taken" + stopwatch.ElapsedMilliseconds);




            Console.WriteLine("Parallel.For:");
            Console.WriteLine();

            stopwatch.Start();
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i);
            });

            stopwatch.Stop();
            Console.WriteLine("Time taken" + stopwatch.ElapsedMilliseconds);
        }

    }
}
