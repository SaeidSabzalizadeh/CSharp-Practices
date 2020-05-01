using System;
using System.Diagnostics;
using System.Threading;
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



        public static void LogConsole(string message)
        {
            Console.WriteLine(GetLog(message));
        }

        public static void LogOutput(string message)
        {
            Debug.WriteLine(GetLog(message));
        }


        private static string GetLog(string message)
        {
            return $"{GetLogPrefix()}: {message}";
        }

        private static string GetLogPrefix()
        {
            return $"{(Task.CurrentId.HasValue ? $"Task[{(Task.CurrentId.Value > 9 ? $"{Task.CurrentId.Value}" : $"0{Task.CurrentId.Value}")}] | " : "")}Thread[{(Thread.CurrentThread.ManagedThreadId > 9 ? $"{Thread.CurrentThread.ManagedThreadId}" : $"0{Thread.CurrentThread.ManagedThreadId}")}] - {DateTime.Now:mm:ss.fffff}";

        }



    }

    public enum ThreadType
    {
        Main = 1,
        Worker = 2
    }

}
