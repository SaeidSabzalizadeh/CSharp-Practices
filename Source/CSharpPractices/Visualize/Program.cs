using System;
using System.Threading.Tasks;

namespace Visualize
{
    class Program
    {
        static async Task Main(string[] args)
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
            //MultiThreading.Signaling.CountdownEventFeatures.Run();

            //MultiThreading.TPL.ParallelFor.Run();
            //MultiThreading.TPL.ParallelForeachModifyPictures.Run();
            //MultiThreading.TPL.Cancellation.Run();
            //MultiThreading.TPL.TaskContinuationWithState.Run();
            //MultiThreading.TPL.TaskCompletionSourceFeatures.Run();

            //MultiThreading.PLINQ.SimplePLINQ.Run();
            //MultiThreading.PLINQ.WithDegreeOfParallelism.Run();
            //MultiThreading.PLINQ.ConcurrencyBag.Run();

            //MultiThreading.TAP.AsyncFeatures.Run();


            //MultiThreading.ConcurrentCollections.ConcurrentQueueFeatures.Run();
            //MultiThreading.ConcurrentCollections.ConcurrentDictionaryFeatures.Run();
            //MultiThreading.ConcurrentCollections.ProducerConsumerPattern.Run();

            //MultiThreading.AsyncProgramming.AsynAwait.Run2();
            //await new MultiThreading.AsyncProgramming.AsynAwait().Run();



            //InterviewQuestions.RecursiveReverseString.Run();
            //InterviewQuestions.FizzBuzz.Run();
            //InterviewQuestions.ReorderList.Run();
            //InterviewQuestions.PopularFeatures.Run();
            //InterviewQuestions.OverlapRectangles.Run();
            //InterviewQuestions.PalindromeString.Run();
            InterviewQuestions.IntersectionRectangle.Run();




            Console.ReadLine();
        }
    }
}
