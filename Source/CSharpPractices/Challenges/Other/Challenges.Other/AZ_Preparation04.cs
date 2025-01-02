using System;
using System.Collections.Generic;

namespace Challenges.Other;

public class AZ_Preparation04
{
    public static bool Run1(string input)
    {
        var tracks = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(' || input[i] == '{' || input[i] == '[')
            {
                if (!tracks.ContainsKey(input[i]))
                {
                    tracks[input[i]] = 1;
                }
                else
                {
                    tracks[input[i]] = tracks[input[i]] + 1;
                }
            }

            if (input[i] == ')' || input[i] == '}' || input[i] == ']')
            {
                char ot = OpenType(input[i]);
                if (!tracks.ContainsKey(ot) || tracks[ot] == 0)
                {
                    return false;
                }

                tracks[ot] = tracks[ot] - 1;
            }
        }

        return
            (!tracks.ContainsKey('(') || tracks['('] == 0) &&
            (!tracks.ContainsKey('{') || tracks['{'] == 0) &&
            (!tracks.ContainsKey('[') || tracks['['] == 0);

    }

    public static bool Run2(string input)
    {
        var stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();
                if (!IsMatchingPair(top, c))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    private static bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }



    private static char OpenType(char v)
    {
        if (v == ')')
        {
            return '(';
        }

        if (v == '}')
        {
            return '{';
        }

        if (v == ']')
        {
            return '[';
        }

        return '0';
    }
}
