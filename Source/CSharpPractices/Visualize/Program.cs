using System;

namespace Visualize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".................................");

            //MultiThreading.ContextSwitching.Run();
            //MultiThreading.SharedResource.Run();
            //MultiThreading.ThreadPoolFeatures.Run();
            //MultiThreading.WaitForThreadCompletion.Run();
            MultiThreading.ExceptionHandling.Run();

            Console.ReadLine();
        }
    }
}
