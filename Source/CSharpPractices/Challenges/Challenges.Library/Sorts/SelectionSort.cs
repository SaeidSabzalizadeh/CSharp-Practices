namespace Challenges.Library.Sorts
{
    public class SelectionSort
    {
        public static int[] Sort(int[] entry)
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

    }
}
