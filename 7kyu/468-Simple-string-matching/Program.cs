using System;
using System.Text.RegularExpressions;

namespace Solution
{
    public static class Solution
    {
        public static bool Solve(string a, string b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j <= b.Length - i; j++)
                {
                    if (b == a.Replace("*", b.Substring(i, j)))
                    {
                        return true;
                    }
                }
            }
            return false;

            // Alternative 1
            // Regex checker = new Regex("^" + a.Replace("*", "[a-z]*") + "$");
            //   return checker.IsMatch(b);

            // Alternative 2
            // return new Regex($"^{a.Replace("*", ".*")}$").IsMatch(b);

            // Alternative 3
            // string[] temp = a.Split('*');
            //  if (temp.Length == 1){
            //     return (a == b);
            //   }
            //   return (temp[0] == b[..temp[0].Length] && temp[1] == b[^temp[1].Length..]);
        }

        public static void Main()
        {
            Console.WriteLine(Solve("code*s", "codewars"));
            Console.WriteLine(Solve("codewar*s", "codewars"));
            Console.WriteLine(Solve("*c", "c"));
            Console.WriteLine(Solve("*", "asterisk"));
        }
    }
}