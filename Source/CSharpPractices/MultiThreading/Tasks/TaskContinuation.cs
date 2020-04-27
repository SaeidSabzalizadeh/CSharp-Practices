using System;
using System.Threading.Tasks;

namespace MultiThreading.Tasks
{
    public class TaskContinuation
    {
        public static void Run()
        {
            Task<string> antecedent = Task.Run(() =>
            {
                Console.WriteLine("I'm antecedent task");
                Task.Delay(1000);
                return DateTime.Today.ToShortDateString();
            });

            Task<string> continuation = antecedent.ContinueWith(x =>
            {
                Console.WriteLine("I'm continuation task");
                return "Today is " + antecedent.Result;
            });

            Console.WriteLine("This will display before the result");
            Console.WriteLine(continuation.Result);
        }

    }
}
