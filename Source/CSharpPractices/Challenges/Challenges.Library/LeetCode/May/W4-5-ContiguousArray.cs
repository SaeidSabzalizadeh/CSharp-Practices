namespace Challenges.Library.LeetCode.May
{
    public class ContiguousArray
    {

        /*
         
        Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1.

        Input: [0,1]
        Output: 2
        Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.

        Input: [0,1,0]
        Output: 2
        Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.

        Note: The length of the given binary array will not exceed 50,000.
         
         */

        public static int FindMaxLength(int[] nums)
        {
            int maxCount = 0;
            int currentCount = 0;
            int currentTotalCount = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                currentCount = 0;
                currentTotalCount = 0;

                for (int i = j; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        currentCount++;
                        currentTotalCount++;
                    }
                    else if (nums[i] == 1)
                    {
                        currentCount--;
                        currentTotalCount++;
                    }

                    if (currentCount == 0 && (currentTotalCount > maxCount))
                    {
                        maxCount = currentTotalCount;
                    }

                    if (nums[i] != 0 && nums[i] != 1)
                    {
                        currentCount = 0;
                        currentTotalCount = 0;
                    }

                }
            }


            return maxCount;

        }

        public static int FindMaxLengthII(int[] nums)
        {
            int maxCount = 0;
            int currentCount = 0;
            int currentTotalCount = 0;
            int firstIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 0)
                {
                    currentCount++;
                    currentTotalCount++;
                }
                else if (nums[i] == 1)
                {
                    currentCount--;
                    currentTotalCount++;
                }



                if (currentCount == 0)
                {
                    if (currentTotalCount > maxCount)
                        maxCount = currentTotalCount;
                }

                else if (i > 1)
                {
                    int cloneCurrentCount = currentCount;
                    int forLength = currentCount < 0 ? currentCount * -1 : currentCount;

                    int index = firstIndex;

                    for (int j = 0; j < forLength; j++)
                    {
                        if (nums[index] == 0)
                        {
                            cloneCurrentCount--;
                        }
                        else if (nums[index] == 1)
                        {
                            cloneCurrentCount++;
                        }

                        index++;

                        int tempCurrentTotalCount = currentTotalCount - j - 1;

                        if (cloneCurrentCount == 0 && tempCurrentTotalCount > maxCount)
                        {
                            firstIndex = index;
                            currentTotalCount = tempCurrentTotalCount;
                            maxCount = currentTotalCount;
                            currentCount = 0;
                            break;
                        }
                    }

                }

                if (nums[i] > 1 || nums[i] < 0)
                {
                    currentCount = 0;
                    currentTotalCount = 0;
                }

            }


            return maxCount;

        }

        public static int FindMaxLengthIII(int[] nums)
        {
            int maxCount = 0;
            int currentCount = 0;
            int currentTotalCount = 0;
            int lastIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 0)
                {
                    currentCount++;
                    currentTotalCount++;
                }
                else if (nums[i] == 1)
                {
                    currentCount--;
                    currentTotalCount++;
                }


                if (currentCount == 0)
                {
                    if (currentTotalCount > maxCount)
                    {
                        lastIndex = i;
                        maxCount = currentTotalCount;
                    }
                }

                if (nums[i] > 1 || nums[i] < 0)
                {
                    currentCount = 0;
                    currentTotalCount = 0;
                }
            }


            if(lastIndex < nums.Length - 1)
            {

            }





            return maxCount;

        }

    }
}
