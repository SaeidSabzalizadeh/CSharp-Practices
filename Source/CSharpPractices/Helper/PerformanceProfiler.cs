using System;
using System.Diagnostics;

namespace Helper
{
    public class PerformanceProfiler
    {
        public static double Check(Action action)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
           
            action.Invoke();
            
            stopWatch.Stop();
            TimeSpan elapsed = stopWatch.Elapsed;

            return elapsed.TotalMilliseconds;
        }
    }
}
