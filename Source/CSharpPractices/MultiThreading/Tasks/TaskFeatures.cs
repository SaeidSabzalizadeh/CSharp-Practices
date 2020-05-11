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
            Helper.LogConsole(taskThatReturns.Result);

            Task<string> taskThatReturns2 = new Task<string>(()=> 
            {
                Helper.LogConsole("ManualMethodThatReturns: Hello World");
                Thread.Sleep(1000);
                return "ManualHello";
            });
            taskThatReturns2.Start();
            taskThatReturns2.Wait();
            Helper.LogConsole(taskThatReturns2.Result);



        }

        private static string MethodThatReturns()
        {
            Helper.LogConsole("MethodThatReturns: Hello World");
            Thread.Sleep(1000);
            return "Hello";
        }

        private static void SimpleMethod()
        {
            Helper.LogConsole("SimpleMethod: Hello World");
        }

    }
}
