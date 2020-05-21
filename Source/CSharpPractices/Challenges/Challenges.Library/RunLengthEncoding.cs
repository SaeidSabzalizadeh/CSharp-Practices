using System;
using System.Text;

namespace Challenges.Library
{
    public class RunLengthEncoding
    {

        public static string Encode(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] characters = input.ToCharArray();
            int count = 1;
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < characters.Length; i++)
            {
                if (characters[i] == characters[i - 1])
                {
                    count++;
                }
                else
                {
                    sb.Append(count);
                    sb.Append(characters[i - 1]);
                    count = 1;
                }
            }

            sb.Append(count);
            sb.Append(characters[characters.Length - 1]);


            string encodedString = sb.ToString();
            return encodedString;
        }

        //public static string Decode(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return input;

        //    if (!char.IsDigit(input[0]))
        //        throw new InvalidOperationException("Input is not RunLengthEncoded");

        //    if (char.IsDigit(input[input.Length - 1]))
        //        throw new InvalidOperationException("Input is not RunLengthEncoded");


        //    char[] characters = input.ToCharArray();
        //    int count = 1;
        //    StringBuilder sb = new StringBuilder();

        //    for (int i = 0; i < characters.Length; i++)
        //    {



        //    }


        //    string encodedString = sb.ToString();
        //    return encodedString;

        //}


    }
}
