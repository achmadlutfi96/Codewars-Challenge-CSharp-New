using System.Linq;
using System;
using System.Text.RegularExpressions;
public class Kata
{
  public static string StringClean(string s)
  {
    // Function will return the cleaned string
    char[] numbers = new char[] { '0', '1', '2','3', '4', '5', '6', '7', '8', '9'};
    return String.Concat(s.Where(i=>!numbers.Contains(i)).ToArray());

    // Alternative 1
    // return Regex.Replace(s, @"\d", "");
    // Alternative 2
    // return String.Join("", s.Where(x => !Char.IsDigit(x)));

  }
  public static void Main(){
    Console.WriteLine(StringClean("Dsa32 cdsc34232 csa!!! 1I 4Am cool!"));
  }
}