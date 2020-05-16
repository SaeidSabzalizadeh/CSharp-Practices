using System;

namespace Challenges.Library
{
    public class OverlapRectangles
    {
        public static void Run()
        {
            Tuple<int, int> rectangle1Low = new Tuple<int, int>(2,3);
            Tuple<int, int> rectangle1Up = new Tuple<int, int>(5, 6);


            Tuple<int, int> rectangle2Low = new Tuple<int, int>(3, 4);
            Tuple<int, int> rectangle2Up = new Tuple<int, int>(4, 5);

            bool isOverlap = IsRectanglesOverlap(rectangle1Low, rectangle1Up, rectangle2Low, rectangle2Up);

            Console.WriteLine($"Rectangle1[({rectangle1Low.Item1},{rectangle1Low.Item2}), ({rectangle1Up.Item1},{rectangle1Up.Item2})], Rectangle2[({rectangle2Low.Item1},{rectangle2Low.Item2}), ({rectangle2Up.Item1},{rectangle2Up.Item2})] {(isOverlap ? "Overlaped*" : "Not Overlaped!")}");

        }

        private static bool IsRectanglesOverlap(Tuple<int, int> rectangle1Low, Tuple<int, int> rectangle1Up, Tuple<int, int> rectangle2Low, Tuple<int, int> rectangle2Up)
        {
            Tuple<int, int> rectangle1XBoundries = new Tuple<int, int>(rectangle1Low.Item1, rectangle1Up.Item1);
            Tuple<int, int> rectangle1YBoundries = new Tuple<int, int>(rectangle1Low.Item2, rectangle1Up.Item2);

            Tuple<int, int> rectangle2XBoundries = new Tuple<int, int>(rectangle2Low.Item1, rectangle2Up.Item1);
            Tuple<int, int> rectangle2YBoundries = new Tuple<int, int>(rectangle2Low.Item2, rectangle2Up.Item2);


            bool isOverlapedInX = IsOverlapedInAxis(rectangle1XBoundries, rectangle2XBoundries);
            bool isOverlapedInY = IsOverlapedInAxis(rectangle1YBoundries, rectangle2YBoundries);


            bool result = isOverlapedInX && isOverlapedInY;

            return result;
        }

        private static bool IsOverlapedInAxis(Tuple<int, int> rectangle1AxisBoundries, Tuple<int, int> rectangle2AxisBoundries)
        {
            if (IsInBetween(rectangle1AxisBoundries.Item1, rectangle2AxisBoundries))
                return true;

            if (IsInBetween(rectangle1AxisBoundries.Item2, rectangle2AxisBoundries))
                return true;

            if (IsInBetween(rectangle2AxisBoundries.Item1, rectangle1AxisBoundries))
                return true;

            if (IsInBetween(rectangle2AxisBoundries.Item2, rectangle1AxisBoundries))
                return true;

            return false;

        }

        private static bool IsInBetween(int point, Tuple<int, int> rectangleBoundries)
        {
            return point >= rectangleBoundries.Item1 && point <= rectangleBoundries.Item2;
        }
    }
}
