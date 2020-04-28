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
            //MultiThreading.Tasks.TaskContinuation.Run();
            //MultiThreading.Synchronization.Monitors.Run();
            //MultiThreading.Synchronization.DeadLocks.Run();
            //MultiThreading.Synchronization.ReaderWriterLocks.Run();
            //MultiThreading.Synchronization.ReaderWriterLocks.SecondWay.Run();
            //MultiThreading.Synchronization.MutexFeatures.Run();
            //MultiThreading.Synchronization.Semaphores.Run();
            //MultiThreading.Signaling.AutoResteEventFeatures.Run();
            //MultiThreading.Signaling.TwoWaySignaling.Run();
            //MultiThreading.Signaling.ManualResteEventFeatures.Run();
            MultiThreading.Signaling.CountdownEventFeatures.Run();




            Console.ReadLine();
        }
    }
}
