using System;
using System.Threading;

namespace MultiThreading.Synchronization
{
    public class DeadLocks
    {

        public static void Run()
        {
            object lockerA = new object();
            object lockerB = new object();

            new Thread(() =>
            {
                lock (lockerA)
                {
                    Console.WriteLine("lockerA obtained by worker thread");
                    Thread.Sleep(2000);
                    lock (lockerB)
                    {
                        Console.WriteLine("lockerB obtained by worker thread");
                    }
                }
            }).Start();


            lock (lockerB)
            {
                Console.WriteLine("lockerB obtained by main thread");
                Thread.Sleep(1000);
                lock (lockerA)
                {
                    Console.WriteLine("lockerA obtained by main thread");
                }
            }
        }

    }
}
