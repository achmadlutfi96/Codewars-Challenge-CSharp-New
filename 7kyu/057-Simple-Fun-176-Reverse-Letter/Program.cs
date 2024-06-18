namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Kata
    {
        public static string ReverseLetter(string str){
          //coding and coding..
          return string.Concat(str.Where(x=>Regex.IsMatch(x.ToString(), @"[a-zA-Z]")).Reverse());

          // Alternative
        //   return new String(str.Where(Char.IsLetter).Reverse().ToArray());
        }

        public static void Main(string[] args){
            Console.WriteLine(ReverseLetter("ultr53o?n"));
        }
    }
}