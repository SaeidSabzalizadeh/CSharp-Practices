using System;
using System.Threading;

namespace MultiThreading.Threads
{
    public class WaitForThreadCompletion
    {
        public static void Run()
        {
            Thread thread = new Thread(PrintHelloWorld);
            thread.Start();
            thread.IsBackground = true;
            thread.Join();
            Console.WriteLine("Hello World printed");
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
            Thread.Sleep(5000);
        }
    }
}
