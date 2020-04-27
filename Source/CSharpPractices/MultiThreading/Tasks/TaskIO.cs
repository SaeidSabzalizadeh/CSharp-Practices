using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.Tasks
{
    public class TaskIO
    {
        public static void Run()
        {

            //1
            Task<string> task1 = Task.Factory.StartNew<string>(() => GetPosts("https://jsonplaceholder.typicode.com/posts"));
            SomethingElse();

            try
            {
                //task1.Wait();
                Console.WriteLine(task1.Result);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Task1 exception: {0}", ex.Message);
            }




            //2
            Task<string> task2 = Task.Factory.StartNew<string>(() => GetPostsButApiReturnedException("https://jsonplaceholder.typicode.com/posts"));
            SomethingElse();

            try
            {
                //task2.Wait();
                Console.WriteLine(task2.Result);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Task2 exception: {0}", ex.Message);
            }
        }



        private static void SomethingElse()
        {
            //Dummy implementation
        }

        private static string GetPosts(string url)
        {
            using (var client = new System.Net.WebClient())
            {
                return client.DownloadString(url);
            }
        }

        private static string GetPostsButApiReturnedException(string url)
        {
            throw null;
        }

    }
}
