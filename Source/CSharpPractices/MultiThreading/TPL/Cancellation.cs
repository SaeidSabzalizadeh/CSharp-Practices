using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.TPL
{
    public class Cancellation
    {

        static long total = 0;
        static int[] list = Enumerable.Range(0, 100000000).ToArray();

        public static void Run()
        {

            System.Threading.CancellationTokenSource cancellationTokenSource = new System.Threading.CancellationTokenSource();

            System.Threading.Tasks.ParallelOptions parallelOptions = new System.Threading.Tasks.ParallelOptions();
            parallelOptions.CancellationToken = cancellationTokenSource.Token;
            parallelOptions.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

            Console.WriteLine("Press 'x' to cancel");

            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'x')
                {
                    Console.WriteLine();
                    cancellationTokenSource.Cancel();
                }
            });


            int fromInclusive = 0;
            int toExclusive = list.Length;

            try
            {
                //parallelOptions.CancellationToken.ThrowIfCancellationRequested();
                Parallel.For<long>(fromInclusive, toExclusive, parallelOptions, LocalInit, Body, LocalFinally);
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine("Cancelled by user " + e.Message);
            }
            finally
            {
                cancellationTokenSource.Dispose();
            }

            Console.WriteLine("The final sum is {0}", total);
        }

        private static long LocalInit()
        {
            return 0;
        }

        private static void LocalFinally(long subtotal)
        {
            System.Threading.Interlocked.Add(ref total, subtotal);
        }

        private static long Body(int count, System.Threading.Tasks.ParallelLoopState parallelLoopState, long subtotal)
        {
            Thread.Sleep(200);
            subtotal += list[count]; // 0 + 1 + 2 + ...... end = ?
            return subtotal;
        }

    }
}
