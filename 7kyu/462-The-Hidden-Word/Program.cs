using System;
using System.Linq;
namespace CodeWars
{
    public class Kata
    {
        public static string hidden(int num)
        {
            // Code here
            char[] w= new char[]{'o','b','l','i','e','t','a','d','n','m'};
            return string.Concat(num.ToString().Select(x=>w[(int)char.GetNumericValue(x)]));

            // Alternative 1
            // string key = "oblietadnm";
            // return new string(num.ToString().Select(x => key[int.Parse(x.ToString())]).ToArray());

            // Alternative 2
            // return string.Concat($"{num}".Select(c => "oblietadnm"[c - '0']));
        }

        public static void Main()
        {
            Console.WriteLine(hidden(7415));
        }
    }
}