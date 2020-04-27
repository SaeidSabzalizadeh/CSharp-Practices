using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultiThreading.Synchronization
{
    public class ReaderWriterLocks
    {
        static System.Threading.ReaderWriterLockSlim readerWriterLockSlim = new System.Threading.ReaderWriterLockSlim();
        static Dictionary<int, string> persons = new Dictionary<int, string>();
        static Random random = new Random();
       
        public static void Run()
        {
            var task1 = Task.Factory.StartNew(Read);
            var task2 = Task.Factory.StartNew(Write, "user2");
            var task3 = Task.Factory.StartNew(Write, "user3");
            var task4 = Task.Factory.StartNew(Read);
            var task5 = Task.Factory.StartNew(Read);
            var task6 = Task.Factory.StartNew(Write, "user6");
            var task7 = Task.Factory.StartNew(Read);
            var task8 = Task.Factory.StartNew(Read);
            var task9 = Task.Factory.StartNew(Read);
            var task10 = Task.Factory.StartNew(Read);
            var task11 = Task.Factory.StartNew(Read);
            var task12 = Task.Factory.StartNew(Read);
            var task13 = Task.Factory.StartNew(Read);
            var task14 = Task.Factory.StartNew(Read);

            Task.WaitAll(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14);
        }

        static void Read()
        {
            for (int i = 0; i < 10; i++)
            {
                readerWriterLockSlim.EnterReadLock();
                System.Threading.Thread.Sleep(50);
                Console.WriteLine("Reader");
                readerWriterLockSlim.ExitReadLock();
            }
        }

        static void Write(object user)
        {
            for (int i = 0; i < 10; i++)
            {
                //int id = random.Next(2000, 5000);
                int id = GetRandom();
                if (persons.ContainsKey(id))
                {
                    Console.WriteLine("Wrtiter: duplicatekey: {0}", id);
                }
                else
                {
                    var person = "Person " + i;

                    readerWriterLockSlim.EnterWriteLock();
                    persons.Add(id, person);
                    readerWriterLockSlim.ExitWriteLock();

                    Console.WriteLine("Wrtiter: Write by : {0} - {1}[{2}]", user, person, id);
                }
                System.Threading.Thread.Sleep(250);
            }
        }

        static int GetRandom()
        {
            lock (random)
            {
                return random.Next(2000, 5000);
            }
        }


        public class SecondWay
        {
            static Dictionary<int, string> personsII = new Dictionary<int, string>();
            private static object lockerObject = new object();


            static Random randomII = new Random();

            public static void Run()
            {
                var task1 = Task.Factory.StartNew(ReadII);
                var task2 = Task.Factory.StartNew(WriteII, "user2");
                var task3 = Task.Factory.StartNew(WriteII, "user3");
                var task4 = Task.Factory.StartNew(ReadII);
                var task5 = Task.Factory.StartNew(ReadII);
                var task6 = Task.Factory.StartNew(WriteII, "user6");
                var task7 = Task.Factory.StartNew(ReadII);
                var task8 = Task.Factory.StartNew(ReadII);
                var task9 = Task.Factory.StartNew(ReadII);
                var task10 = Task.Factory.StartNew(ReadII);
                var task11 = Task.Factory.StartNew(ReadII);
                var task12 = Task.Factory.StartNew(ReadII);
                var task13 = Task.Factory.StartNew(ReadII);
                var task14 = Task.Factory.StartNew(ReadII);

                Task.WaitAll(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14);
            }

            static void ReadII()
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(50);
                    Console.WriteLine("Reader");
                }
            }

            static void WriteII(object user)
            {
                for (int i = 0; i < 10; i++)
                {
                    //int id = random.Next(2000, 5000);
                    int id = GetRandom();
                    if (personsII.ContainsKey(id))
                    {
                        Console.WriteLine("Wrtiter: duplicatekey: {0}", id);
                    }
                    else
                    {
                        var person = "Person " + i;
                        lock (lockerObject)
                        {
                            personsII.Add(id, person);
                        }
                        Console.WriteLine("Wrtiter: Write by : {0} - {1}[{2}]", user, person, id);
                    }

                    System.Threading.Thread.Sleep(250);
                }
            }

            static int GetRandom()
            {
                lock (randomII)
                {
                    return randomII.Next(2000, 5000);
                }
            }
        }



    }
}
