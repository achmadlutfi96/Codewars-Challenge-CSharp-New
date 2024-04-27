using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Kata
{
  public static int LowercaseCountCheck(string s)
  {
    // your code goes here ...
    return s.Count(i=>Char.IsLower(i));

    // Alternative 
    // return Regex.Matches(s, "[a-z]").Count;
  }

  public static void Main(){
    Console.WriteLine(LowercaseCountCheck("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~"));
  }
}