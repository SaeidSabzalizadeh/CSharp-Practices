using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Signaling
{
    public class ManualResteEventFeatures
    {
        //Same things here
        //static System.Threading.EventWaitHandle eventWaitHandle = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.ManualReset);
        //static System.Threading.EventWaitHandle eventWaitHandle = new System.Threading.ManualResetEvent(false);
        static System.Threading.ManualResetEvent eventWaitHandle = new System.Threading.ManualResetEvent(false);
        public static void Run()
        {

            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);

            Thread.Sleep(1000);
            Console.WriteLine("Press a key to release all the threads so far");
            Console.ReadKey();
            eventWaitHandle.Set();
            Thread.Sleep(1000);

            Console.WriteLine("Press a key again. Threads won't block even if they call WaitOne");
            Console.ReadKey();
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Thread.Sleep(1000);

            Console.WriteLine("Press a key again. Threads will block if they call WaitOne");
            Console.ReadKey();
            eventWaitHandle.Reset();
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Task.Factory.StartNew(CallWaitOne);
            Thread.Sleep(1000);

            Console.WriteLine("Press a key again. Calls Set()");
            Console.ReadKey();
            eventWaitHandle.Set();
            Console.ReadLine();

        }

        private static void CallWaitOne()
        {
            Helper.WriteMessageByTask("Has called WaitOne");
            eventWaitHandle.WaitOne();
            Thread.Sleep(400);
            Helper.WriteMessageByTask("Finally ended");
        }
    }
}
