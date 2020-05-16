using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.Library
{
    public class ReorderList
    {
        public static void Run()
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("strings have space separated parts");
            Console.WriteLine("first part is identifier and rest is content");
            Console.WriteLine("Algorithm should Order list by content ");
            Console.WriteLine("in Tigh situation order by tights");
            Console.WriteLine("Use ASCII order which numbers are first");
            Console.WriteLine("integer content will leave in same order as it is.");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            string[] list = new string[]
            {
                "g23 aaa 3 1a sdasd",
                "acd 31123",
                "xcd 31asd asd",
                "sda 2131 23",
                "f23 aaa 3 1a sdasd",
            };

            var ordered = ReOrder(5, list);

            Console.WriteLine("Main List:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Ordered List:");
            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------");
        }

        public static List<string> ReOrder(int logFileSize, string[] logLines)
        {
            List<KeyValuePair<string, string>> identifyContent = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> integerContent = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < logFileSize; i++)
            {
                var line = logLines[i];
                var identify = line.Substring(0, line.IndexOf(' '));
                var content = line.Substring(line.IndexOf(' ') + 1);

                var checkValue = content;
                if (content.IndexOf(' ') > 0)
                    checkValue = content.Substring(content.IndexOf(' ') + 1);

                bool isInt = int.TryParse(checkValue, out _);

                if (isInt)
                    integerContent.Add(new KeyValuePair<string, string>(identify, content));
                else
                    identifyContent.Add(new KeyValuePair<string, string>(identify, content));
            }

            var orderedListAlphabet = identifyContent.OrderBy(x => x.Value).ThenBy(x => x.Key);

            List<KeyValuePair<string, string>> orderedList = new List<KeyValuePair<string, string>>();

            orderedList.AddRange(orderedListAlphabet);
            orderedList.AddRange(integerContent);

            return orderedList.Select(x => string.Format("{0} {1}", x.Key, x.Value)).ToList();

        }

    }
}
