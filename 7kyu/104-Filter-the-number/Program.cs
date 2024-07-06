using System;
using System.Linq;

public class Kata
{
  public static int FilterString(string s)
  {
    //Your code goes here
    return int.Parse(string.Concat(s.Where(x=>char.IsDigit(x))));

    // Alternative
    // return int.Parse(string.Concat(s.Where(char.IsNumber)));
  }

  public static void Main(){
    Console.WriteLine(FilterString("aa1bb2cc3dd"));
  }
}