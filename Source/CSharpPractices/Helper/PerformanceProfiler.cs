using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Helper
{
    public class PerformanceProfiler
    {
        public static double Check(Action action)
        {
            const int numberOfIterations = 10000;
            double[] allElapsed = new double[numberOfIterations];

            var stopWatch = new Stopwatch();

            for (int i = 0; i < numberOfIterations; i++)
            {
                stopWatch.Start();

                action.Invoke();

                stopWatch.Stop();
                allElapsed[i] = stopWatch.Elapsed.TotalMilliseconds;
                stopWatch.Reset();
            }

            double avg = Math.Round(allElapsed.Average(), 5);

            return avg;
        }

        public static void Compare(Dictionary<string, Action> dictionary)
        {
            Sort(dictionary.Select(x => new KeyValuePair<string, double>(x.Key, Check(x.Value))).ToDictionary(x => x.Key, x => x.Value));
        }

        public static void Sort(Dictionary<string, double> dictionary)
        {
            var orderedList = dictionary.OrderBy(x => x.Value).ToList();
            int padLength = orderedList.Max(x => x.Key.Length) + 2;

            for (int i = 0; i < orderedList.Count; i++)
            {
                Base.AddItem($"{orderedList[i].Key}:", $"{i + 1}- {orderedList[i].Value} {(i > 0 ? $"+{Math.Round((((orderedList[i].Value - orderedList[i - 1].Value) * 100) / orderedList[i - 1].Value), 2)}%" : "")}", padLength);
            }

        }

    }
}
