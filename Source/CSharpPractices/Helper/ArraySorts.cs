using System.Linq;

namespace Helper
{
    public class ArraySorts
    {
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
