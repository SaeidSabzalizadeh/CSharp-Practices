using System.IO;
using System.Threading.Tasks;

namespace MultiThreading.ConcurrentCollections
{
    public class ConcurrentDictionaryFeatures
    {
        static System.Collections.Concurrent.ConcurrentDictionary<int, string> cd = new System.Collections.Concurrent.ConcurrentDictionary<int, string>();
        public static void Run()
        {
            //if (cd.TryAdd(1, "one"))
            //{
            //    Console.WriteLine("KVP 1:one Was Added!");
            //}

            //string val = cd.GetOrAdd(1, "ONE");
            //Console.WriteLine("Existing 1: {0}", val);

            //string val2 = cd.AddOrUpdate(1, "_ONE_",
            //    (int existingKey, string existingValue) => 
            //    {
            //        return existingValue.ToUpper();
            //    });
            //Console.WriteLine("Existing 1: {0}", val2);

            //if (cd.TryGetValue(1, out string val3))
            //{
            //    Console.WriteLine("Existing value: ", val3);
            //}

            //cd.GetOrAdd()

            string filename = $@"{Directory.GetCurrentDirectory()}\sample.txt";
            string[] lines = File.ReadAllLines(filename);

            Parallel.ForEach<string>(lines,
                (string line) =>
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (string.IsNullOrWhiteSpace(word)) continue;

                        string canonicalWord = word.Trim(' ', ',', '.', '?', '!', ';', '-', ':', '\'', '\"').ToLowerInvariant();

                        wordCount.AddOrUpdate(canonicalWord, 1, (key, currentCount) => { return currentCount + 1; });
                    }
                });

        }
        static System.Collections.Concurrent.ConcurrentDictionary<string, uint> wordCount = new System.Collections.Concurrent.ConcurrentDictionary<string, uint>();
    }

}
