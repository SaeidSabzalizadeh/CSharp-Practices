using System;

namespace Visualize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".................................");

            //MultiThreading.Threads.ContextSwitching.Run();
            //MultiThreading.Threads.SharedResource.Run();
            //MultiThreading.Threads.ThreadPoolFeatures.Run();
            //MultiThreading.Threads.WaitForThreadCompletion.Run();
            //MultiThreading.Threads.ExceptionHandling.Run();

            //MultiThreading.Tasks.TaskFeatures.Run();
            //MultiThreading.Tasks.TaskIO.Run();
            MultiThreading.Tasks.TaskContinuation.Run();

            Console.ReadLine();
        }
    }
}
