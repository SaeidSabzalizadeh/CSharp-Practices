using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.PLINQ
{
    public class WithDegreeOfParallelism
    {
        public static void Run()
        {
            List<string> websites = new List<string>();
            websites.Add("www.apple.com");
            websites.Add("www.google.com");
            websites.Add("www.microsoft.com");

            List<PingReply> responses =
                websites.AsParallel()
                .WithDegreeOfParallelism(websites.Count)
                .Select(PingSites).ToList();


            Console.WriteLine();
            Console.WriteLine("Final Result:");
            Console.WriteLine();
            foreach (var response in responses)
            {
                Console.WriteLine($"Pinged - Status: {response.Status} > RoundtripTime:{response.RoundtripTime}, Address: [{response.Address}] ");
            }

            Console.ReadLine();
        }

        private static PingReply PingSites(string websiteName)
        {
            Ping ping = new Ping();
            var response = ping.Send(websiteName);

            Console.WriteLine($"Thread({Thread.CurrentThread.ManagedThreadId}) Task[{Task.CurrentId ?? -1}] - {DateTime.Now.ToString("mm:ss.fffff")} Pinged - Status: {response.Status} > RoundtripTime:{response.RoundtripTime}, Address: [{response.Address}] - '{websiteName}'");
            return response;
        }
    }
}
