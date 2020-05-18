using System;

namespace CSharp
{
    public class Operators
    {
        public static void Run()
        {

            uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b = ~a;

            Console.WriteLine($" a: {a}");
            Console.WriteLine($"~a: {b}");
            Console.WriteLine();
            Console.WriteLine($" a toBase(2): 0000{Convert.ToString(a, toBase: 2)}");
            Console.WriteLine($"~a toBase(2): {Convert.ToString(b, toBase: 2)}");

            // Output:
            // 11110000111100001111000011110011

        }

        public static uint BitwiseComplement(uint input)
        {
            return ~input;
        }


        public static uint LeftShift(uint input, int shiftNumber)
        {
            return input << shiftNumber;
        }

        public static uint RightShift(uint input, int shiftNumber)
        {
            return input >> shiftNumber;
        }
    }
}
