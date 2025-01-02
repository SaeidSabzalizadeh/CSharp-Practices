using System.Collections.Generic;

namespace Challenges.Other;

public class AZ_Preparation05
{
    public static int[] Run1(int[] input)
    {
        var total = 1;

        HashSet<int> zeros = new HashSet<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 0)
            {
                zeros.Add(i);
                continue;
            }

            total = total * input[i];
        }

        int[] output = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 0)
            {
                output[i] = total;
            }
            else if (zeros.Count > 0)
            {
                output[i] = 0;
            }
            else
            {
                output[i] = total / input[i];
            }
        }

        return output;

    }
}
