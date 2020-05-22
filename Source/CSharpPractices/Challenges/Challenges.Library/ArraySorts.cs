using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.Library
{
    public class ArraySorts
    {

        public static void Run()
        {
            Helper.Base.Start(typeof(ArraySorts));

            List<int> cc = new List<int>();
            Random ran = new Random();

            for (int i = 0; i < 50000; i++)
            {
                cc.Add(ran.Next(1, 500));
            }

            int[] longArray = cc.ToArray();

            Helper.Base.AddItem("Start comparing:", $"long array length: {longArray.Length}");

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                 { "BubbleSort", () => { int[] result = BubbleSort(longArray);}},
                 { "InsertionSort", () => { int[] result = InsertionSort(longArray);}},
                 { "SelectionSort", () => { int[] result = SelectionSort(longArray);}},
                 { "LinqSort", () => { int[] result = LinqSort(longArray);}},

            }, 4); ;

            Helper.Base.End(typeof(ArraySorts));
        }

        public static int[] BubbleSort(int[] entry)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < entry.Length - 1; i++)
                {
                    if (entry[i] > entry[i + 1])
                    {
                        int temp = entry[i + 1];
                        entry[i + 1] = entry[i];
                        entry[i] = temp;
                        swapped = true;
                    }

                }
            } while (swapped);

            return entry;
        }

        public static int[] InsertionSort(int[] entry)
        {
            int currentItem;

            for (int i = 1; i < entry.Length; i++)
            {
                currentItem = entry[i];
                int currentIndex = i;

                while (currentIndex > 0 && entry[currentIndex - 1] > currentItem)
                {
                    entry[currentIndex] = entry[currentIndex - 1];
                    currentIndex--;
                }

                entry[currentIndex] = currentItem;
            }

            return entry;
        }

        public static int[] SelectionSort(int[] entry)
        {
            int minValue;
            int minValueIndex;

            for (int i = 0; i < entry.Length; i++)
            {
                minValue = entry[i];
                minValueIndex = i;

                for (int j = i + 1; j < entry.Length; j++)
                {
                    if (entry[j] < minValue)
                    {
                        minValue = entry[j];
                        minValueIndex = j;
                    }
                }

                int temp = entry[i];
                entry[i] = minValue;
                entry[minValueIndex] = temp;
            }

            return entry;

        }

        public static int[] LinqSort(int[] entry)
        {
            return entry.OrderBy(x => x).ToArray();
        }

    }
}
