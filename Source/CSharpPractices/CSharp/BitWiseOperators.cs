using System;

namespace CSharp
{
    public class BitWiseOperators
    {
        public static void Run()
        {
            Helper.Base.Start(typeof(BitWiseOperators));

            uint a = 2345678;
            uint b = 252645132;

            Helper.Base.AddItem("Declare numeric value in Base2: 'uint b = 0b_0000_1111_0000_1111_0000_1111_0000_1100;'");
            Helper.Base.AddItem("Get string in Base2: 'uint a = 2345678; string str = Convert.ToString(a, toBase: 2);'");
            Helper.Base.AddItem($"Output: {Convert.ToString(a, toBase: 2)}");
            Helper.Base.AddItem($"SizeOf(uint): {sizeof(uint) * 8}bits So all Base2 uint has {sizeof(uint) * 8}bits");
            Helper.Base.AddItem($"Means Actual Value of Convert.ToString(a, toBase: 2) is: {Convert.ToString(a, toBase: 2).PadLeft(32, '0')}");
            Helper.Base.AddItem($"Now ................................................ ~a: {Convert.ToString(~a, toBase: 2)}");
            Helper.Base.AddNewSection();
            Helper.Base.AddItem($"Assume 'uint b = 252645132;' in Base2 is        : {Convert.ToString(b, toBase: 2).PadLeft(32, '0')}");
            Helper.Base.AddItem($"And ........................ in Base2 Wellformed: {Helper.Base.GetBase2WellFormed(Convert.ToString(b, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"And ..................................... b << 2: {Helper.Base.GetBase2WellFormed(Convert.ToString(b << 2, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"And ..................................... b >> 2: {Helper.Base.GetBase2WellFormed(Convert.ToString(b >> 2, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"And ......................................... ~b: {Helper.Base.GetBase2WellFormed(Convert.ToString(~b, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddNewSection();
            Helper.Base.AddItem($"a  is: {Helper.Base.GetBase2WellFormed(Convert.ToString(a, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"And b: {Helper.Base.GetBase2WellFormed(Convert.ToString(b, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"  a|b: {Helper.Base.GetBase2WellFormed(Convert.ToString((a | b), toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"  a&b: {Helper.Base.GetBase2WellFormed(Convert.ToString((a & b), toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"  a^b: {Helper.Base.GetBase2WellFormed(Convert.ToString((a ^ b), toBase: 2).PadLeft(32, '0'))}");

            Helper.Base.End(typeof(BitWiseOperators));

        }

    }
}
