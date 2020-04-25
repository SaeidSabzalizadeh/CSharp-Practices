using System;
using System.Threading;

namespace MultiThreading
{
    public class ContextSwitching
    {
        public static void Run()
        {
            Thread thread = new Thread(WriteUsingNewThread);
            thread.Name = "Cazton Worker";
            //Worker Thread
            thread.Start();
           
            //Main Thread
            Thread.CurrentThread.Name = "Cazton main";
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" A" + i + " ");
            }
        }

        private static void WriteUsingNewThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" Z" + i + " ");
            }
        }


    }
}
