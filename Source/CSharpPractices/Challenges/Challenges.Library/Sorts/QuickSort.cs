namespace Challenges.Library.Sorts
{
    public class QuickSort
    {
        public static int[] Sort(int[] entry)
        {
            Quick_Sort(entry, 0, entry.Length - 1);

            return entry;
        }
        static int Partition(int[] array, int low,
                                    int high)
        {
            //1. Select a pivot point.
            int pivot = array[high];

            int lowIndex = (low - 1);

            //2. Reorder the collection.
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        static void Quick_Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                //3. Recursively continue sorting the array
                Quick_Sort(array, low, partitionIndex - 1);
                Quick_Sort(array, partitionIndex + 1, high);
            }
        }

        //private static void Quick_Sort(int[] arr, int start, int end)
        //{
        //    int i;
        //    if (start < end)
        //    {
        //        i = Partition(arr, start, end);

        //        Quick_Sort(arr, start, i - 1);
        //        Quick_Sort(arr, i + 1, end);
        //    }
        //}

        //private static int Partition(int[] arr, int start, int end)
        //{
        //    int temp;
        //    int p = arr[end];
        //    int i = start - 1;

        //    for (int j = start; j <= end - 1; j++)
        //    {
        //        if (arr[j] <= p)
        //        {
        //            i++;
        //            temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }

        //    temp = arr[i + 1];
        //    arr[i + 1] = arr[end];
        //    arr[end] = temp;
        //    return i + 1;
        //}


    }
}
