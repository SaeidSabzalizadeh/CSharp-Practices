using System;
using System.Threading;

namespace MultiThreading.Synchronization
{
    public class MutexFeatures
    {
        static System.Threading.Mutex mutex = new System.Threading.Mutex();

        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {

                Thread thread = new Thread(UseLimitedWaitResource);
                thread.Name = $"Thread{i + 1}";
                thread.Start();
            }


            for (int i = 10; i < 20; i++)
            {

                Thread thread = new Thread(UseResource);
                thread.Name = $"Thread{i + 1}";
                thread.Start();
            }


        }


        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);

            mutex.WaitOne();
            Console.WriteLine("{0} has entered the protected area", Thread.CurrentThread.Name);
            DoSomething();

            mutex.ReleaseMutex();
            Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);
        }

        private static void UseLimitedWaitResource()
        {
            Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);

            if (mutex.WaitOne(1000))
            {
                Console.WriteLine("{0} has entered the protected area", Thread.CurrentThread.Name);
                DoSomething();

                mutex.ReleaseMutex();
                Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);

            }
            else
            {
                Console.WriteLine("{0} will not acquire the mutex", Thread.CurrentThread.Name);
            }
        }


        private static void DoSomething()
        {
            Thread.Sleep(500);

        }
    }

}
