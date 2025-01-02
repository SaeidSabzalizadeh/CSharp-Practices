using System.Collections.Generic;

namespace Challenges.Other;

public class AZ_Preparation03
{
    public static int[] Run1(int[] input, int target)
    {
        int index = 0;
        for (int i = 0; i < input.Length; i++)
        {
            index = i + 1;
            while (index < input.Length)
            {
                if (input[i] + input[index] == target)
                {
                    return new int[] { i, index };
                }
                index++;
            }
        }
        return new int[] { -1, -1 };
    }


    public static int[] Run2(int[] input, int target)
    {
        var numDic = new Dictionary<int, int>();

        for (int i = 0; i < input.Length; i++)
        {
            var complement = target - input[i];
            if (numDic.ContainsKey(complement))
            {
                return new int[] { numDic[complement], i };
            }

            if (!numDic.ContainsKey(input[i]))
            {
                numDic[input[i]] = i;
            }
        }

        return new int[] { -1, -1 };
    }

}
