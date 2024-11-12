using System;
using System.Linq;

namespace Solution 
{
    public static class Kata 
    {
        public static double TArea(string s) 
        {
            return Math.Pow(s.Split("\n").Length-1, 2) / 2;
        }

        public static void Main()
        {
            Console.WriteLine(TArea(". \n. .\n. . .\n. . . ."));
            Console.WriteLine(TArea(". \n. ."));
        }
    }
}