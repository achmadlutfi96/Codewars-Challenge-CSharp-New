using System;
using System.Linq;

public class Kata
{
  public static string SortGiftCode(string code)
  {
    //TODO
    return string.Concat(code.OrderBy(x=>x).ToArray());
  }

  public static void Main(){
    Console.WriteLine(SortGiftCode("zyxwvutsrqponmlkjihgfedcba"));
  }
}