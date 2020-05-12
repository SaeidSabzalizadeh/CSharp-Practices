using System;

namespace InterviewQuestions
{
    public class IntersectionRectangle
    {
        public static void Run()
        {

            var rectangle1 = new Rectangle() { Top = 6, Buttom = 2, Left = 1, Right = 5 };
            var rectangle2 = new Rectangle() { Top = 3, Buttom = 1, Left = 3, Right = 7 };

            var answer = new Rectangle() { Top = 3, Buttom = 2, Left = 3, Right = 5 };
            Rectangle intersection = GetIntersection(rectangle1, rectangle2);


            Console.WriteLine($"Right answer is:         {answer}");
            Console.WriteLine($"Founded intersection is: { (intersection == null ? "NULL" : intersection.ToString())}");

        }

        private static Rectangle GetIntersection(Rectangle rectangle1, Rectangle rectangle2)
        {
            Rectangle result = new Rectangle();


            if (InMiddleX(rectangle1.Left, rectangle2))
                result.Left = rectangle1.Left;
            else if (InMiddleX(rectangle2.Left, rectangle1))
                result.Left = rectangle2.Left;


            if (InMiddleX(rectangle1.Right, rectangle2))
                result.Right = rectangle1.Right;
            else if (InMiddleX(rectangle2.Right, rectangle1))
                result.Right = rectangle2.Right;

            if (InMiddleY(rectangle1.Top, rectangle2))
                result.Top = rectangle1.Top;
            else if (InMiddleY(rectangle2.Top, rectangle1))
                result.Top = rectangle2.Top;


            if (InMiddleY(rectangle2.Buttom, rectangle1))
                result.Buttom = rectangle2.Buttom;
            else if (InMiddleY(rectangle1.Buttom, rectangle2))
                result.Buttom = rectangle1.Buttom;

            return result;


        }

        private static bool InMiddleX(int point, Rectangle rectangle)
        {
            return point >= rectangle.Left && point <= rectangle.Right;
        }

        private static bool InMiddleY(int point, Rectangle rectangle)
        {
            return point >= rectangle.Buttom && point <= rectangle.Top;
        }

    }


    public class Rectangle
    {
        public int Top { get; set; } //Y
        public int Buttom { get; set; } //Y
        public int Right { get; set; } //X
        public int Left { get; set; } //X

        public override string ToString()
        {
            return $"[({Left},{Buttom}) , ({Right},{Top})]";
        }


    }


}
