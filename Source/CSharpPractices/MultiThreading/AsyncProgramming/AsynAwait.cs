using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.AsyncProgramming
{
    public class AsynAwait
    {
        public async Task Run()
        {
            Helper.LogConsole("AsynAwait...");
            Console.WriteLine();


            Console.WriteLine("----------------------------------- (1)");
            Console.WriteLine();

            string format1 = "await Task.FromResult";
            Helper.LogConsole($"With {format1}");
            int number1 = await GetNumbersFromResult();

            Helper.LogConsole($"Result > {format1}: {number1}");

            Console.WriteLine("----------------------------------- (2)");
            Console.WriteLine();

            string format2 = "await async Task";
            Helper.LogConsole($"With {format2}");
            int number2 = await GetNumbers();

            Helper.LogConsole($"Result > {format2}: {number2}");


            Console.WriteLine("----------------------------------- (3)");
            Console.WriteLine();

            string format4 = "Start - Wait inline";
            Helper.LogConsole($"With {format4}");
            Task<int> format4Task = new Task<int>(() =>
            {
                _ = Task.Delay(200);
                Thread.Sleep(300);
                Helper.LogConsole("Geting Numbers");
                return 2;
            });

            format4Task.Start();
            format4Task.Wait();
            int number4 = format4Task.Result;

            Helper.LogConsole($"Result > {format4}: {number4}");

            Console.WriteLine("----------------------------------- (4)");
            Console.WriteLine();

            string format3 = "Start - Wait";
            Helper.LogConsole($"With {format3}");
            Task<int> format3Task = GetNumbers();
            format3Task.Start();
            format3Task.Wait();
            int number3 = format3Task.Result;

            Helper.LogConsole($"Result > {format3}: {number3}");


            Console.WriteLine("----------------------------------- (END)");
            Console.WriteLine();

        }

        private Task<int> GetNumbersFromResult()
        {
            _ = Task.Delay(200);
            Thread.Sleep(300);
            Helper.LogConsole("Geting Numbers");
            return Task.FromResult(2);
        }

        public static void Run2()
        {


            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Helper.LogConsole("With START, NoWAIT");
            Task<string> StartNoWaitTask = new Task<string>(() =>
            {
                Helper.LogConsole("START, NoWAIT: Hello World");
                Thread.Sleep(1000);
                return "ManualHello";
            });
            StartNoWaitTask.Start();
            Helper.LogConsole($"START, NoWAIT: {StartNoWaitTask.Result}");



            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Helper.LogConsole("With START, WAIT");
            Task<string> StartWaitTask = new Task<string>(() =>
            {
                Helper.LogConsole("START, WAIT: Hello World");
                Thread.Sleep(1000);
                return "ManualHello";
            });
            StartWaitTask.Start();
            StartWaitTask.Wait();
            Helper.LogConsole($"START, WAIT: {StartWaitTask.Result}");


            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Helper.LogConsole("With NoSTART, NoWAIT");
            Task<string> NoStartWaitTask = new Task<string>(() =>
            {
                Helper.LogConsole("NoSTART, NoWAIT: Hello World");
                Thread.Sleep(1000);
                return "ManualHello";
            });
            Helper.LogConsole($"NoSTART, NoWAIT: {NoStartWaitTask.Result}");


            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Helper.LogConsole("With NoSTART, ButWAIT");
            Task<string> NoStartButWaitTask = new Task<string>(() =>
            {
                Helper.LogConsole("NoSTART, ButWAIT: Hello World");
                Thread.Sleep(1000);
                return "ManualHello";
            });
            NoStartButWaitTask.Wait();
            Helper.LogConsole($"NoSTART, ButWAIT: {NoStartButWaitTask.Result}");


            Console.WriteLine("*******************************************");
            Helper.LogConsole("with Task");
            Task<int> numbersTask = GetNumbersStatic();
            numbersTask.Wait();
            Helper.LogConsole("Ended Task");
            Helper.LogConsole($"Result Task: {numbersTask.Result}");

            Helper.LogConsole("with ManualTask");
            Task<int> newTask = new Task<int>(() =>
            {
                _ = Task.Delay(200);
                Thread.Sleep(300);
                Helper.LogConsole("Geting Numbers Manual");
                return 3;
            });

            Helper.LogConsole("Ended ManualTask");
            Helper.LogConsole($"Result ManualTask: {newTask.Result}");



        }

        private static Task<int> GetNumbersStatic()
        {
            _ = Task.Delay(200);
            Thread.Sleep(300);
            Helper.LogConsole("Geting Numbers");
            return Task.FromResult(2);
        }

        private async Task<int> GetNumbers()
        {
            await Task.Delay(200);
            Thread.Sleep(300);
            Helper.LogConsole("Geting Numbers");
            return 2;

        }
    }
}
