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

            Helper.Base.AddNewSection("TEST");

            int number = 8;
            int half = number >> 1;

            Helper.Base.AddItem($"'int number = 8;'       number: {Helper.Base.GetBase2WellFormed(Convert.ToString(number, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"'int half = number >> 1;' half: {Helper.Base.GetBase2WellFormed(Convert.ToString(half, toBase: 2).PadLeft(32, '0'))}");
            Helper.Base.AddItem($"......................... half: {half}");

            int[] numbers = new[] { 6, 12, 25, 3, 1258, -1258, 5589745, 9999995, 9999998 };

            Helper.Base.AddNewSection("WHY?");
            ChecHalfShiftAll(numbers);

            Helper.Base.AddNewSection("Yes in bitwise each bit equesl 2^{index}");
            Helper.Base.AddNewSection("That means (number / 4) == (number >> 2) ??");
            ChecShiftDivideRelations(numbers, 4, 2);

            Helper.Base.AddNewSection("And (/8) = >> 3");
            ChecShiftDivideRelations(numbers, 8, 3);

            Helper.Base.AddNewSection("So We Could Say (number*8) = (number << 3) Then:");
            ChecShiftDivideRelations(numbers, 8, 3, "left");

            Helper.Base.End(typeof(BitWiseOperators));

        }

        private static void ChecShiftDivideRelations(int[] numbers, int divideOrMultiple, int shiftCount, string shiftSide = "right")
        {
            foreach (var number in numbers)
                ChecShiftDivideRelation(number, divideOrMultiple, shiftCount, shiftSide);
        }

        private static void ChecShiftDivideRelation(int number, int divideOrMultiple, int shiftCount, string shiftSide)
        {
            int shiftedValue = (shiftSide == "right") ? number >> shiftCount : number << shiftCount;
            int calculatedValue = (shiftSide == "right") ? number / divideOrMultiple : number * divideOrMultiple;

            Helper.Base.AddNewSection();
            Helper.Base.AddItem($"Number is:", number);
            Helper.Base.AddItem($"Real {(shiftSide == "right" ? "Divide" : "Multiple")} by {divideOrMultiple} is:", calculatedValue);
            Helper.Base.AddItem($"Shift {shiftSide} by {shiftCount} is:", shiftedValue);
            Helper.Base.AddItem($"VALIDATE:", (shiftedValue == calculatedValue).ToString().ToUpper());
            Helper.Base.AddItem($"number:", Helper.Base.GetBase2WellFormed(Convert.ToString(number, toBase: 2).PadLeft(32, '0')));
            Helper.Base.AddItem($"Shifted {shiftSide}:", Helper.Base.GetBase2WellFormed(Convert.ToString(shiftedValue, toBase: 2).PadLeft(32, '0')));
        }

        private static void ChecHalfShiftAll(int[] numbers)
        {
            ChecShiftDivideRelations(numbers, 2, 1, "right");
        }

    }
}
