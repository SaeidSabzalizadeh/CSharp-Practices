using System;

namespace Helper
{
    public static class Base
    {
        const int TotalTitleLength = 100;
        public static void Start(Type classType)
        {
            SetPads($" START {classType.Name} ");
            Console.WriteLine();
        }

        public static void End(Type classType)
        {
            Console.WriteLine();
            SetPads($" END {classType.Name} ");
        }

        public static void AddItem(string content)
        {
            Console.WriteLine($"  - {content}");
        }

        public static void AddNewSection()
        {
            Console.WriteLine();
        }
        public static void AddNewSection(string content)
        {
            Console.WriteLine();
            SetPads($"  {content} ", TotalTitleLength / 2);
            Console.WriteLine();
        }

        public static string GetBase2WellFormed(string content)
        {
            if (string.IsNullOrEmpty(content))
                return null;

            if (content.Length <= 4)
                return content;

            return $"{content.Substring(0, 4)}_{GetBase2WellFormed(content.Substring(4))}";
        }

        private static void SetPads(string content, int totalTitleLength = TotalTitleLength)
        {
            int padRightLength = (totalTitleLength + content.Length) / 2;
            Console.WriteLine($" {content.PadRight(padRightLength, '-').PadLeft(totalTitleLength, '-')}");
        }


    }
}

