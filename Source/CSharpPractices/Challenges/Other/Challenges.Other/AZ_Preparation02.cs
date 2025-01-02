using System;

namespace Challenges.Other;


/// <summary>
/// Problem: Find the Duplicate Number
/// Given an array of integers nums containing n + 1 integers 
/// where each integer is in the range [1, n] inclusive, 
/// there is only one repeated number in nums, return this repeated number.
/// 
/// Example:
/// Input: nums = [1,3,4,2,2]
/// Output: 2
/// </summary>
public class AZ_Preparation02
{
    public static int Run1(int[] input)
    {
        int index = -1;
        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j <= index; j++)
            {
                if (numbers[j] == input[i])
                {
                    return input[i];
                }
            }

            index++;
            numbers[index] = input[i];
        }

        return -1000;
    }
}
