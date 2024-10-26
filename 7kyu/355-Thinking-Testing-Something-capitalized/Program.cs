namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static string Testit(string s)
        {
            return s.Length == 0 ? "" : string.Join(" ", s.Split(" ").Select(x => x.Substring(0, x.Length - 1) + x.Last().ToString().ToUpper()));

            //   Alternative 
            // return Regex.Replace(s, ".\\b", Word => Word.ToString().ToUpper());
        }

        public static void Main()
        {
            Console.WriteLine(Testit("ab ab"));
        }
    }
}