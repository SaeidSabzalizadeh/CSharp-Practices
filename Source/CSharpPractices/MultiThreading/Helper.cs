using System;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Helper
    {

        public static string GetDate()
        {
            return DateTime.Now.ToString("mm:ss.fffff");
        }

        public static void WriteMessageByTask(string message)
        {
            Console.WriteLine($"{GetDate()} | Task[{Task.CurrentId}] > {message}");
        }

        public static void WriteMessageByThread(string message, ThreadType threadType)
        {
            Console.WriteLine($"{GetDate()} | {threadType} thread > {message}");
        }

        public static void WriteMessageByThread(string message)
        {
            WriteMessageByThread(message, ThreadType.Main);
        }


    }

    public enum ThreadType
    {
        Main = 1,
        Worker = 2
    }

}
