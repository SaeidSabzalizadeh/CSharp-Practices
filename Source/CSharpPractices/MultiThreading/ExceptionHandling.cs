using System;
using System.Threading;

namespace MultiThreading
{
    public class ExceptionHandling
    {
        public static void Run()
        {
            try
            {
                new Thread(ExecuteI).Start();
                new Thread(ExecuteII).Start();
            }
            catch (Exception ex)
            {
                //Never reach this line.
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Got Exception in Run: {0}", ex.Message);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine();
            }
        }


        static void ExecuteI()
        {
            throw new Exception("Execute1 exception");
        }

        static void ExecuteII()
        {
            try
            {
                throw new Exception("Execute2 exception");
            }
            catch (Exception ex)
            {
                //The right way to catch exception. because this try-catch is in running thread
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Got Exception in ExecuteII: {0}", ex.Message);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine();
            }

        }

    }
}
