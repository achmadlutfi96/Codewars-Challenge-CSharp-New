// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

namespace Solution
{
    public class Kata
    {
        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10)
            {
                return 100;
            }
            else if (exam > 75 && projects >= 5)
            {
                return 90;
            }
            else if (exam > 50 && projects >= 2)
            {
                return 75;
            }
            else
            {
                return 0;
            }
        }
        public static void Main()
        {
            Console.WriteLine(FinalGrade(100, 12));
        }
    }
}

