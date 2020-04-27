using System;
using System.Threading;

namespace MultiThreading.Synchronization
{
    public class Semaphores
    {
        static System.Threading.SemaphoreSlim semaphoreSlim = new System.Threading.SemaphoreSlim(3);
        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(EnterSemaphore).Start(i + 1);
            }
        }

        private static void EnterSemaphore(object id)
        {
            Console.WriteLine(id + " is waiting to be part of the club");
            semaphoreSlim.Wait();
            Console.WriteLine(id + " now is part of the club");
            Thread.Sleep(1000 / (int)id);
            Console.WriteLine(id + " left the club");
        }
    }
}
