using System;
using System.Threading.Tasks;

namespace Visualize
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine();

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

            //await new MultiThreading.AsyncProgramming.AsynAwait().Run();



            //Challenges.Library.RecursiveReverseString.Run();
            //Challenges.Library.FizzBuzz.Run();
            //Challenges.Library.ReorderList.Run();
            //Challenges.Library.PopularFeatures.Run();
            //Challenges.Library.OverlapRectangles.Run();
            //Challenges.Library.PalindromeString.Run();
            //Challenges.Library.IntersectionRectangle.Run();
            //Challenges.Library.IncreasingSubsequence.Run();
            //Challenges.Library.ReadWebRequest.Run();
            //Challenges.Library.LongestIncreasingSubsequence.Run();
            //Challenges.Library.ArraySorts.Run();
            //Challenges.Library.LeetCode.RansomNote.Run();
            //Challenges.Library.LeetCode.FirstUniqueCharacter.Run();
            //Challenges.Library.LeetCode.MajorityElement.Run();

            Challenges.Library.LeetCode.CousinsInBinaryTree.Run();




            //CSharp.BitWiseOperators.Run();


            Console.ReadLine();
        }
    }
}
