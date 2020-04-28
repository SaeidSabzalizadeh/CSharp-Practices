using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Signaling
{
    public class TwoWaySignaling
    {
        static EventWaitHandle first = new AutoResetEvent(false);
        static EventWaitHandle second = new AutoResetEvent(false);
        static object caztonLock = new object();
        static string value = string.Empty;
        public static void Run()
        {
            Task.Factory.StartNew(WorkerThread);
            Helper.WriteMessageByThread("Waiting for first event", ThreadType.Main);
            first.WaitOne();
            Helper.WriteMessageByThread("Accessed to first event", ThreadType.Main);
            lock (caztonLock)
            {
                value = "Updating value in main thread";
                Helper.WriteMessageByThread(value, ThreadType.Main);
            }
            Thread.Sleep(1000);
            second.Set();
            Helper.WriteMessageByThread("Released second event", ThreadType.Main);
        }

        private static void WorkerThread()
        {
            Thread.Sleep(1000);
            lock (caztonLock)
            {
                value = "Updating value in worked thread";
                Helper.WriteMessageByThread(value, ThreadType.Worker);
            }
            first.Set();
            Helper.WriteMessageByThread("Released first event", ThreadType.Worker);
            Helper.WriteMessageByThread("Waiting for second event", ThreadType.Worker);
            second.WaitOne();
            Helper.WriteMessageByThread("Accessed to second event", ThreadType.Worker);
        }

    }

}
