// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Text;

namespace Solution
{
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            string res ="";
            for(int i = 0; i < n; i++){
                res += s;
            }
            return res;

            // Alternative 1
            // return String.Concat(Enumerable.Repeat(s, n));
            // Alternative 2
            // return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        }
        public static void Main()
        {
            Console.WriteLine(RepeatStr(3, "*"));
        }
    }
}