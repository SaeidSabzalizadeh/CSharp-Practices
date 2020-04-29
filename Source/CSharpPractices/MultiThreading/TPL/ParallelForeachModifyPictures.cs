using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.TPL
{
    public class ParallelForeachModifyPictures
    {
        public static void Run()
        {
            var path = Directory.GetCurrentDirectory();
            var files = Directory.GetFiles(path + @"\TPL\Pictures", "*.jpg");
            var alteredPathNormal = path + @"\TPL\AlteredPathNormal";
            var alteredPathParallel = path + @"\TPL\AlteredPathParallel";
            Directory.CreateDirectory(alteredPathNormal);
            Directory.CreateDirectory(alteredPathParallel);

            NormalExecution(files, alteredPathNormal);
            ParallelExecution(files, alteredPathParallel);


        }

        private static void ParallelExecution(string[] files, string alteredPath)
        {
            Console.WriteLine("ParallelExecution:");
            Console.WriteLine();

            Stopwatch stopwatch = Stopwatch.StartNew();
            Parallel.ForEach(files, currentFile =>
            {
                var file = Path.GetFileName(currentFile);
                using (var fileBitmap = new Bitmap(currentFile))
                {
                    fileBitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                    fileBitmap.Save(Path.Combine(alteredPath, file));
                    Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);
                }
            });
            Console.WriteLine("ParallelExecution " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            stopwatch.Stop();
        }

        private static void NormalExecution(string[] files, string alteredPath)
        {

            Console.WriteLine("NormalExecution:");
            Console.WriteLine();

            Stopwatch stopwatch = Stopwatch.StartNew();
            foreach (var currentFile in files)
            {
                var file = Path.GetFileName(currentFile);
                using (var fileBitmap = new Bitmap(currentFile))
                {
                    fileBitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                    fileBitmap.Save(Path.Combine(alteredPath, file));
                    Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);
                }
            }
            Console.WriteLine("NormalExecution " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
            stopwatch.Stop();

        }

    }
}
