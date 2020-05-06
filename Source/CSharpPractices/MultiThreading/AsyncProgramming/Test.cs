using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.AsyncProgramming
{
    public class Test
    {
        public async Task Run()
        {
            Helper.LogConsole("Running...");
            int number = await GetNumbers();
            Helper.LogConsole("Ended");
        }

        private Task<int> GetNumbers()
        {
            Task.Delay(200);
            Thread.Sleep(300);
            Helper.LogConsole("Geting Numbers");
            return Task.FromResult(2);
        }
    }
}
