using System;
using System.Linq;
public class Kata
{
  public static string Contamination(string text, string character)
  {
    // Code here ;)
    return String.Concat(text.Select(s => character));
  }

  public static void Main(){
    Console.WriteLine(Contamination("abc", "z"));
  }
}