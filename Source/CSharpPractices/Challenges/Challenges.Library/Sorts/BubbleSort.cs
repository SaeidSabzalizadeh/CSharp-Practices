namespace Challenges.Library.Sorts
{
    public class BubbleSort
    {

        public static int[] Sort(int[] entry)
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

    }
}
