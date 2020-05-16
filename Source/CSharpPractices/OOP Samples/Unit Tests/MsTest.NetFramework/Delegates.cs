using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MSTest.NetFramework
{
    [TestClass]
    public class Delegates
    {

        delegate void DoSomethingDelegate();


        [TestMethod]
        public void TestDelegates_Phase1()
        {
            Log("Start TestDelegates");

            DoSomethingDelegate somethingDelegate = new DoSomethingDelegate(DoSomething);
            somethingDelegate();

            Thread.Sleep(100);
            Log("End TestDelegates");

        }

        [TestMethod]
        public void TestDelegates_Phase2()
        {
            Log("Start TestDelegates");

            DoSomethingDelegate somethingDelegate = new DoSomethingDelegate(DoSomething);

            var result = somethingDelegate.BeginInvoke(null, null);

            Thread.Sleep(100);
            Log("Meantime in TestDelegates");

            somethingDelegate.EndInvoke(result);


            Log("End TestDelegates");

        }

        [TestMethod]
        public void TestDelegates_Phase3()
        {
            Log("Start TestDelegates");

            DoSomethingDelegate somethingDelegate = new DoSomethingDelegate(DoSomething);

            var result = somethingDelegate.BeginInvoke(CallBack, somethingDelegate);
            Thread.Sleep(100);
            Log("Meantime in TestDelegates");
            Log("End TestDelegates");

        }

        [TestMethod]
        public void TestDelegates_Phase4()
        {
            Log("Start TestDelegates");

            DoSomethingDelegate somethingDelegate = new DoSomethingDelegate(DoSomething);

            var result = somethingDelegate.BeginInvoke(CallBack, somethingDelegate);
            Thread.Sleep(100);
            Log("Meantime in TestDelegates");

            result.AsyncWaitHandle.WaitOne();

            Log("End TestDelegates");

        }

        [TestMethod]
        public void TestDelegates_Phase5()
        {
            Log("Start TestDelegates");

            DoSomethingDelegate somethingDelegate = new DoSomethingDelegate(DoSomethingElse);

            var result = somethingDelegate.BeginInvoke(CallBack, somethingDelegate);
            Thread.Sleep(100);
            Log("Meantime in TestDelegates");

            result.AsyncWaitHandle.WaitOne();

            Log("End TestDelegates");

        }

        private void CallBack(IAsyncResult asyncResult)
        {
            try
            {

                Log("CallBack Doing something .....");
                var somethingDelegate = asyncResult.AsyncState as DoSomethingDelegate;
                Thread.Sleep(500);
                somethingDelegate.EndInvoke(asyncResult);
                Thread.Sleep(500);
                Log("End of Doing something .....");

            }
            catch (Exception ex)
            {
                Log($"Catch Exception in CallBack: {ex.Message}");
            }

        }

        private void DoSomethingElse()
        {
            Thread.Sleep(500);
            Log("Doing something else .....");
            throw new Exception("DoSomethingElse exception");
        }

        

        private void DoSomething()
        {
            Thread.Sleep(500);
            Log("Doing something .....");
        }

        private void Log(string message)
        {
            Debug.WriteLine($"{GetLogPrefix()}: {message}");
        }

        private object GetLogPrefix()
        {
            return $"{(Task.CurrentId.HasValue ? $"Task[{(Task.CurrentId.Value > 9 ? $"{Task.CurrentId.Value}" : $"0{Task.CurrentId.Value}")}] | " : "")}Thread[{(Thread.CurrentThread.ManagedThreadId > 9 ? $"{Thread.CurrentThread.ManagedThreadId}" : $"0{Thread.CurrentThread.ManagedThreadId}")}] - {DateTime.Now:mm:ss.fffff}";

        }

    }
}
