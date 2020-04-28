using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Signaling
{
    public class AutoResteEventFeatures
    {

        //Same things here
        //static System.Threading.EventWaitHandle eventWaitHandle = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.AutoReset);
        //static System.Threading.EventWaitHandle eventWaitHandle = new System.Threading.AutoResetEvent(false);
        static System.Threading.AutoResetEvent eventWaitHandle = new System.Threading.AutoResetEvent(true);


        public static void Run()
        {
            Task.Factory.StartNew(WorkerThread);
            Task.Factory.StartNew(WorkerThread);
            Task.Factory.StartNew(WorkerThread);
            Thread.Sleep(2500);

            Helper.WriteMessageByThread("Set the gate", ThreadType.Main);
            eventWaitHandle.Set();
        }

        private static void WorkerThread()
        {
            Helper.WriteMessageByTask("Waiting to enter the gate");
            eventWaitHandle.WaitOne();
            //Logic
            Helper.WriteMessageByTask("Entered to gate");
            Thread.Sleep(500);

            Helper.WriteMessageByTask("Set the gate");
            eventWaitHandle.Set();
        }

    }

}