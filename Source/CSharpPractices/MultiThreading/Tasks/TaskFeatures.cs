using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Tasks
{
    public class TaskFeatures
    {
        public static void Run()
        {
            Task task = new Task(SimpleMethod);
            task.Start();


            Task<string> taskThatReturns = new Task<string>(MethodThatReturns);
            taskThatReturns.Start();
            taskThatReturns.Wait();
            Console.WriteLine(taskThatReturns.Result);
        }

        private static string MethodThatReturns()
        {
            Thread.Sleep(1000);
            return "Hello";
        }

        private static void SimpleMethod()
        {
            Console.WriteLine("Hello World");
        }

    }
}
