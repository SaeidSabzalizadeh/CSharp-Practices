using System;
using System.Threading;

namespace MultiThreading
{
    public class ThreadPoolFeatures
    {
        public static void Run()
        {

            Employee employee = new Employee();
            employee.Name = "Saeid";
            employee.CompanyName = "Saeid co.";

            ThreadPool.QueueUserWorkItem(new WaitCallback(DisplayEmployeeInfo), employee);

            var processorCount = Environment.ProcessorCount;
            Console.WriteLine("Current machine ProcessorCount: {0}", processorCount);
            ThreadPool.SetMaxThreads(processorCount * 2, processorCount * 2);

            int minWorkerThreads = 0;           //usually equal to Environment.ProcessorCount
            int minCompletionPortThreads = 0;   //usually equal to Environment.ProcessorCount
            ThreadPool.GetMinThreads(out minWorkerThreads, out minCompletionPortThreads);

            //So we can also SetMaxThreads like this:
            ThreadPool.SetMaxThreads(minWorkerThreads * 2, minCompletionPortThreads * 2);

            Console.WriteLine("Run > IsThreadPoolThread: {0}", Thread.CurrentThread.IsThreadPoolThread);

            Console.ReadKey();
        }

        private static void DisplayEmployeeInfo(object employee)
        {
            Console.WriteLine("DisplayEmployeeInfo > IsThreadPoolThread: {0}", Thread.CurrentThread.IsThreadPoolThread);
            Employee emp = employee as Employee;
            Console.WriteLine("Person name is {0} and company name is {1}", emp.Name, emp.CompanyName);
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
    }

}
