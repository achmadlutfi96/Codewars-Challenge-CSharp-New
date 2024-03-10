using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word)
  {
    //TODO
    return word ? "Yes" : "No"; 
  }

  public static void Main(){
    Console.WriteLine(boolToWord(true));
  }
}
