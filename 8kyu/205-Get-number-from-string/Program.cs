using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solution
{
    public static class Program
    {
        public static int getNumberFromString(string s)
        {
            return Convert.ToInt32(string.Concat(s.Where(v => Regex.IsMatch(v.ToString(), @"[0-9]")).ToArray()));

            // Alternative 1
            // return Int32.Parse(Regex.Replace(s, @"[^\d]", ""));

            // Alternative 2
            // return int.Parse(string.Concat(s.Where(char.IsDigit)));
        }

        public static void Main()
        {
            Console.WriteLine(getNumberFromString("this is number: 7"));
        }
    }
}