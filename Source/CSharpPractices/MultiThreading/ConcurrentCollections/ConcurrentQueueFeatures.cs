using System;
using System.Threading;

namespace MultiThreading.ConcurrentCollections
{

    public class ConcurrentQueueFeatures
    {
        static Random rnd = new Random();
        static System.Collections.Concurrent.ConcurrentQueue<ulong> cq = new System.Collections.Concurrent.ConcurrentQueue<ulong>();

        public static void Run()
        {
            Thread threadFib = new Thread(new ThreadStart(GenerateFib));
            threadFib.IsBackground = false; //make it foreground thread to application will ot exit without complition of this thread
            threadFib.Start();

            Thread threadReader = new Thread(new ThreadStart(ReadFib));
            threadReader.IsBackground = false;
            threadReader.Start();
        }

        private static void ReadFib()
        {
            Console.WriteLine("Starting to read from the queue...");

            do
            {
                if (cq.TryDequeue(out ulong n))
                {
                    Console.Write("[Fib {0}]", n);
                }
                else
                {
                    //Console.Write(".");
                }
                Thread.Sleep(10);
            } while (true);
        }

        private static void GenerateFib()
        {
            for (ushort ix = 0; ix < 50; ix++)
            {
                Thread.Sleep(rnd.Next(1, 500));
                cq.Enqueue(Fibonacci(ix));
            }
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
