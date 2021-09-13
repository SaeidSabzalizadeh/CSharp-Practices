using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode.Hard
{
    public class N0166_FractionToRecurringDecimal
    {
        public static string FractionToDecimal(int numerator, int denominator)
        {
            if (denominator == 0)
                return null;


            int multiplyer = 1;
            if (numerator < 0)
                multiplyer *= -1;

            if (denominator < 0)
                multiplyer *= -1;

            int floats = 0;
            double result = 0;
            int currentResult = 0;
            int currentReminder = -1;
            int[] reminders = new int[denominator];
            int reminderIndex = -1; ;
            bool repeatedPatterFounded = false;


            while (currentReminder != 0 || !repeatedPatterFounded)
            {

                while (numerator < denominator)
                {
                    numerator = numerator * 10;
                    floats++;
                }

                currentResult = (numerator / denominator);
                currentReminder = numerator - (currentResult * denominator);

                if (currentReminder > 0)
                {
                    if (floats > 0)
                    {
                        if (reminderIndex > -1)
                        {
                            for (int i = 0; i <= reminderIndex; i++)
                            {
                                if (reminders[i] == currentReminder)
                                {
                                    repeatedPatterFounded = true;
                                    break;
                                }
                            }


                        }
                    }

                    reminderIndex++;
                    reminders[reminderIndex] = currentReminder;
                }





                if (currentReminder == 0)
                    return "";

                if (repeatedPatterFounded)
                    return "";


                numerator = currentReminder;
                floats = 0;



            }



            result = (numerator / denominator) * ((double)1 / Math.Pow(10, floats));

            return null;

        }


       

    }
}
