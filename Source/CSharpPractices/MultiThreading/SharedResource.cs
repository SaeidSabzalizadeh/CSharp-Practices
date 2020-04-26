using System;
using System.Threading;

namespace MultiThreading
{
    public class SharedResource
    {
        private static bool isCompleted;
        static readonly object lockCompleted = new object();

        public static void Run()
        {

            //Worked Thread
            Thread thread = new Thread(HelloWorld);
            thread.Name = "bv Worker";
            thread.Start();

            //Main Thread
            Thread.CurrentThread.Name = "bv main";
            HelloWorld();
        }

        private static void HelloWorld()
        {
            lock (lockCompleted)
            {
                if (!isCompleted)
                {
                    isCompleted = true;
                    Console.WriteLine("Hello World should print only once");
                }
            }

        }

    }
}
