﻿using System;

namespace Challenges.Library.LeetCode
{
    public class StraightLine
    {
        /*
         You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. 
        Check if these points make a straight line in the XY plane.

        Constraints:
        - 2 <= coordinates.length <= 1000
        - coordinates[i].length == 2
        - -10^4 <= coordinates[i][0], coordinates[i][1] <= 10^4
        - coordinates contains no duplicate point.

        Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
        Output: true

        Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
        Output: false


         */


        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates == null || coordinates.Length < 2)
                return false;

            if (coordinates.Length == 2)
                return true;

            Tuple<bool, double, double> lineFunction = GetLineFunctionParameters(coordinates[0], coordinates[1]);

            for (int i = 2; i < coordinates.Length; i++)
            {
                if (!PointIsInLine(lineFunction, coordinates[i]))
                    return false;
            }

            return true;
        }

        private static bool PointIsInLine(Tuple<bool, double, double> lineFunction, int[] point)
        {
            if (!lineFunction.Item1)
                return point[0] == lineFunction.Item2;

            double x1 = point[0];
            double y1 = point[1];

            return y1 == (lineFunction.Item2 * x1) + lineFunction.Item3;
        }

        public static Tuple<bool, double, double> GetLineFunctionParameters(int[] firstPoint, int[] secondPoint)
        {
            if (firstPoint == null || firstPoint.Length != 2 || secondPoint == null || secondPoint.Length != 2)
                return null;

            double x1 = firstPoint[0];
            double y1 = firstPoint[1];

            double x2 = secondPoint[0];
            double y2 = secondPoint[1];

            if (x1 == x2 && y1 == y2)
                return null;

            if (x1 == x2)
                return new Tuple<bool, double, double>(false, x1, x1);

            double a = (y1 - y2) / (x1 - x2);
            double b = ((x1 * y2) - (x2 * y1)) / (x1 - x2);

            return new Tuple<bool, double, double>(true, a, b);
        }

    }
}
