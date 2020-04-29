using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultiThreading.TPL
{
    public class TaskContinuationWithState
    {
        private class Person
        {
            public int Id { get; set; }
        }

        private class TaskResult
        {
            public int Id { get; set; }
            public DateTime EndTime { get; set; }

            public TaskResult(int id, DateTime endTime)
            {
                Id = id;
                EndTime = endTime;
            }

            public override string ToString()
            {
                return $"Id: {Id}, EndTime:{EndTime}";
            }
        }

        public static void Run()
        {

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Continues by pass state.");
            Console.WriteLine();
            Task<TaskResult> task1 = Task.Run(DoSomething);

            //Pass State
            for (int i = 0; i < 3; i++)
            {
                var newTask = task1.ContinueWith(ContinueToDoSomething, new Person { Id = i });
            }


            //Pass State and Keep track
            List<Task<DateTime>> continuationTasks = new List<Task<DateTime>>();
            for (int i = 100; i < 103; i++)
            {
                var newTask = task1.ContinueWith(ContinueToDoSomething, new Person { Id = i });
                continuationTasks.Add(newTask);
            }

            task1.Wait();


            foreach (var continuation in continuationTasks)
            {
                Person person = continuation.AsyncState as Person;
                Console.WriteLine("Task finished at " + continuation.Result + ". State was a Person[{0}]", person.Id);
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
        }


        private static DateTime ContinueToDoSomething(Task<TaskResult> mainTask, object state)
        {
            var mainTaskResult = mainTask.Result;

            Person p = state as Person;
            Console.WriteLine($"Task[{Task.CurrentId ?? -1}] is Continues of > [Main Task: {mainTaskResult}] - State is: {(p != null ? $"Person[{p.Id}]" : "Null")}");
            return DateTime.Now;
        }

        private static TaskResult DoSomething()
        {
            var result = new TaskResult(Task.CurrentId ?? -1, DateTime.Now);
            Console.WriteLine($"Task[{Task.CurrentId ?? -1}] is Main task :{result}");
            return result;
        }
    }
}
