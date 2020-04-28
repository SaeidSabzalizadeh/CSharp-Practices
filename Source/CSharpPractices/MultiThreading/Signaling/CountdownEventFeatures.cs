using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Signaling
{
    public class CountdownEventFeatures
    {
        static int count = 5;
        static System.Threading.CountdownEvent countdownEvent = new System.Threading.CountdownEvent(count);
        public static void Run()
        {

            for (int i = 0; i < count; i++)
            {
                Task.Factory.StartNew(DoSomething); //1---5
            }

            Helper.WriteMessageByThread($"Waiting....  [CurrentCount is: {countdownEvent.CurrentCount}]");
            countdownEvent.Wait();

            Helper.WriteMessageByThread($"Released, Signal has been called {count} times. [CurrentCount is: {countdownEvent.CurrentCount}]");
            Task.Factory.StartNew(DoSomething); //6
            Task.Factory.StartNew(DoSomething); //7
            Task.Factory.StartNew(DoSomething); //8
            Task.Factory.StartNew(DoSomething); //9
            Task.Factory.StartNew(DoSomething); //10

            Helper.WriteMessageByThread($"Waiting....  [CurrentCount is: {countdownEvent.CurrentCount}]");
            countdownEvent.Wait(); // No Wait time bacause CurrentCount is 0; 
            Helper.WriteMessageByThread($"Released. [CurrentCount is: {countdownEvent.CurrentCount}]");

            count = 3;
            Helper.WriteMessageByThread($"Going to add Count of {count}...");
            countdownEvent = new System.Threading.CountdownEvent(count);
            for (int i = 0; i < count; i++)
            {
                Task.Factory.StartNew(DoSomething); // 3times
            }

            Helper.WriteMessageByThread($"Waiting....  [CurrentCount is: {countdownEvent.CurrentCount}]");
            countdownEvent.Wait();
            Helper.WriteMessageByThread($"Released, Signal has been called {count} times. [CurrentCount is: {countdownEvent.CurrentCount}]");


            Helper.WriteMessageByThread($"Going to add Count of {count}...");
            countdownEvent = new System.Threading.CountdownEvent(count);
            for (int i = 0; i < count - 1; i++)
            {
                Task.Factory.StartNew(DoSomething); // 2times
            }

            Helper.WriteMessageByThread($"Waiting.... forever  [CurrentCount is: {countdownEvent.CurrentCount}]");
            Helper.WriteMessageByThread($"Because the last signal never called  [CurrentCount is: {countdownEvent.CurrentCount}]");
            countdownEvent.Wait();

            //Never seen this message
            Helper.WriteMessageByThread($"**Released, Signal has been called {count} times. [CurrentCount is: {countdownEvent.CurrentCount}]");
        }

        private static void DoSomething()
        {
            Thread.Sleep(250);
            Helper.WriteMessageByTask($"is calling signal... [CurrentCount is: {countdownEvent.CurrentCount}]");
            countdownEvent.Signal();
        }
    }
}
