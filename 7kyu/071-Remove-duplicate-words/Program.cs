using System;
using System.Linq;

public static class Kata
{
  public static string RemoveDuplicateWords(string s)
  {
    // throw new NotImplementedException();
    return string.Join(" ",s.Split(" ").Distinct());
  }

  public static void Main(){
    Console.WriteLine(RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"));
  }
}