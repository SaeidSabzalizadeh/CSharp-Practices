using System;
using System.Threading;

namespace MultiThreading.ConcurrentCollections
{
    public class ProducerConsumerPattern
    {
        static Random rnd = new Random();
        static System.Collections.Concurrent.BlockingCollection<ulong> numbers = new System.Collections.Concurrent.BlockingCollection<ulong>(10);

        public static void Run()
        {
            Thread threadFib = new Thread(new ThreadStart(GenerateFib));
            threadFib.IsBackground = false;
            threadFib.Start();

            Thread threadReader = new Thread(new ThreadStart(ReadFib));
            threadReader.IsBackground = false;
            threadReader.Start();
        }

        private static void GenerateFib()
        {
            for (ushort ix = 0; ix < 50; ix++)
            {
                Thread.Sleep(rnd.Next(1, 500));
                Console.WriteLine("Adding next Fib...");
                numbers.Add(Fibonacci(ix)); // Wait for capacity available and then Add
            }
        }
        private static void ReadFib()
        {
            Thread.Sleep(4000);
            do
            {
                var n = numbers.Take(); // Wait for next item available and then Take
                Console.WriteLine("[Fib {0}]", n);
            } while (true);
        }

        private static ulong Fibonacci(ushort n)
        {
            return (n == 0) ? 0 : Fib(n);
        }
        private static ulong Fib(ushort n)
        {
            ulong a = 0;
            ulong b = 1;
            for (uint ix = 0; ix < n - 1; ix++)
            {
                ulong next = checked(a + b);
                a = b;
                b = next;
            }
            return b;
        }
    }
}
