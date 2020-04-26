using MultiThreading;
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
            ThreadPoolFeatures.Run();

            Console.ReadLine();
        }
    }
}
