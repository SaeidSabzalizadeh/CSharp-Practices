using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.TPL
{
    public class TaskCompletionSourceFeatures
    {
        public static void Run()
        {
            System.Threading.Tasks.TaskCompletionSource<Product> taskCompletionSource = new System.Threading.Tasks.TaskCompletionSource<Product>();

            Task.Factory.StartNew(() =>
            {
                //Thread.Sleep(2000);
                Console.WriteLine("Setting Result");
                taskCompletionSource.SetResult(new Product { Id = 1, Name = "Software Development Consulting" });
            });

            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'x')
                {
                    Console.WriteLine();
                    Product result = taskCompletionSource.Task.Result;
                    Console.WriteLine("\n Result is {0}", result.Name);
                }
            });

            Thread.Sleep(5000);
            Console.WriteLine("Done!");
            //Console.ReadLine();
        }


        private class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}
