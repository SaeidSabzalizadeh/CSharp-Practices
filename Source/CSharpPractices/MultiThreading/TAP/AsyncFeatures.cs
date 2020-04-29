using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.TAP
{
    public class AsyncFeatures
    {
        public static void Run()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                tokenSource.Cancel();
            });


            DownloadAsync(new Uri("https://jsonplaceholder.typicode.com/posts"), token).Wait();

        }

        public static async Task DownloadAsync(Uri uri, CancellationToken token)
        {
            var rand = new Random(258);

            try
            {

                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    try
                    {

                        var uniqueNumber = rand.Next(100, 500);
                        HttpResponseMessage result = await GetAsync(uri, uniqueNumber);

                        Console.WriteLine($"{GetLogPrefix(uniqueNumber)}: After calling await for async method");
                        Console.WriteLine($"{GetLogPrefix(uniqueNumber)}: After Xms of calling await for async method");
                        Console.WriteLine($"{GetLogPrefix(uniqueNumber)}: Result is {result.StatusCode}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{GetLogPrefix()} - Exception: {ex.Message}");
                    }
                }

            }
            catch (OperationCanceledException pex)
            {
                Console.WriteLine($"{GetLogPrefix()}: Canceled by user.");
            }

        }

        private static Task<HttpResponseMessage> GetAsync(Uri uri, int uniqueNumber)
        {
            Console.WriteLine($"{GetLogPrefix(uniqueNumber)}: I'm start of async Method");
            Thread.Sleep(100);
            HttpClient client = new HttpClient();
            var result = client.GetAsync(uri);
            Console.WriteLine($"{GetLogPrefix(uniqueNumber)}: I'm end of async Method");
            return result;
        }

        private static string GetLogPrefix(int? uniqueNumber = null)
        {
            return $"Thread[{(Thread.CurrentThread.ManagedThreadId > 9 ? $"{Thread.CurrentThread.ManagedThreadId}" : $"0{Thread.CurrentThread.ManagedThreadId}")}] - {DateTime.Now: mm:ss.fffff}{(uniqueNumber.HasValue ? $" (*{uniqueNumber})" : "")}";
        }
    }
}
