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

            string format1 = "await async Task";
            Helper.LogConsole($"With {format1}");
            int number1 = await GetNumbers("1");

            Helper.LogConsole($"Result > {format1}: {number1}");

            Console.WriteLine("----------------------------------- (R1)");
            Console.WriteLine();

            string formatR1 = "await async Task Repeated";
            Helper.LogConsole($"With {formatR1}");
            int numberR1 = await GetNumbers("R1");

            Helper.LogConsole($"Result > {formatR1}: {numberR1}");



            Console.WriteLine("----------------------------------- (2)");
            Console.WriteLine();

            string format2 = "await Task.FromResult";
            Helper.LogConsole($"With {format2}");
            int number2 = await GetNumbersFromResult("2");

            Helper.LogConsole($"Result > {format2}: {number2}");


            Console.WriteLine("----------------------------------- (3)");
            Console.WriteLine();

            string format3 = "Start - Wait inline";
            Helper.LogConsole($"With {format3}");
            Task<int> format3Task = new Task<int>(() =>
            {
                _ = Task.Delay(200);
                Thread.Sleep(300);
                Helper.LogConsole($"Geting Numbers V3^");
                return 2;
            });

            format3Task.Start();
            format3Task.Wait();
            int number3 = format3Task.Result;

            Helper.LogConsole($"Result > {format3}: {number3}");

            Console.WriteLine("----------------------------------- (4)");
            Console.WriteLine();

            string format4 = "Start - Wait";
            Helper.LogConsole($"With {format4}");
            Task<int> format4Task = GetNumbers("4");
            format4Task.Start();
            format4Task.Wait();
            int number4 = format3Task.Result;

            Helper.LogConsole($"Result > {format4}: {number4}");


            Console.WriteLine("----------------------------------- (END)");
            Console.WriteLine();

        }

        private Task<int> GetNumbersFromResult(string version)
        {
            _ = Task.Delay(200);
            Thread.Sleep(300);
            Helper.LogConsole($"Geting Numbers V{version}!");
            return Task.FromResult(2);
        }

        private async Task<int> GetNumbers(string version)
        {
            await Task.Delay(200);
            Thread.Sleep(300);
            Helper.LogConsole($"Geting Numbers V{version}*");
            return 2;

        }

    }
}
