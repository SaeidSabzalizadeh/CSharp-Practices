using System;
using System.Collections.Generic;
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

            Task<string> continuation1 = antecedent.ContinueWith(x =>
            {
                Console.WriteLine("I'm continuation task 1");
                return "[1]: Today is " + antecedent.Result;
            });


            Task<string> continuation2 = antecedent.ContinueWith(x => //x is an antecedent Task type so we could use it
            {
                Console.WriteLine("I'm continuation task 2");
                return "[2]: Today is " + x.Result; //Here
        });


            Task<int> continuation3 = antecedent.ContinueWith(x => // Continuation task could be any type, here is int
            {
                Console.WriteLine("I'm continuation task 3");
                Console.WriteLine("[3]: Today is " + x.Result);

                return 10003;
            });


            Task<string> antecedent2 = Task.Run(() =>
            {
                Console.WriteLine("I'm antecedent task 2");
                Task.Delay(1000);
                throw new Exception("unexpected exceotion here ...");
                return DateTime.Today.ToShortDateString();

            });





            // Continue in specific condition
            Task<int> continuation4 = antecedent.ContinueWith(ContinuationIfSucceed, TaskContinuationOptions.OnlyOnRanToCompletion);
            Task<int> continuation5 = antecedent2.ContinueWith(ContinuationIfFailed, TaskContinuationOptions.OnlyOnFaulted);


            //Pass state in continuation task
            List<string> samleVariable = new List<string>() { "Item1", "Item2", "Item3", "Item4" };
            Task<int> continuation6 = antecedent.ContinueWith(ContinuationIfSucceedWithState, samleVariable, TaskContinuationOptions.OnlyOnRanToCompletion);


            Console.WriteLine("This will display before the continuation results");
            Console.WriteLine(continuation1.Result);
            Console.WriteLine(continuation2.Result);
            Console.WriteLine(continuation3.Result);
            Console.WriteLine(continuation4.Result);
            Console.WriteLine(continuation5.Result);
            Console.WriteLine(continuation6.Result);
        }



        private static int ContinuationIfSucceed(Task<string> antecedentTask)
        {
            Console.WriteLine("I'm continuation task 4");
            Console.WriteLine("[4]: Today is " + antecedentTask.Result);

            return 10004;
        }

        private static int ContinuationIfFailed(Task<string> antecedentTask)
        {
            Console.WriteLine("I'm continuation task 5");
            Console.WriteLine("[5]: Task raised an exception " + antecedentTask.Exception.Message);

            return 10005;
        }

        private static int ContinuationIfSucceedWithState(Task<string> antecedentTask, object state)
        {
            List<string> stateVariable = state as List<string>;

            Console.WriteLine("I'm continuation task 6");
            Console.WriteLine("[6]: Today is " + antecedentTask.Result);
            Console.WriteLine($"[6]: State is: {string.Join(", ", stateVariable)}");

            return 10006;
        }

    }
}
