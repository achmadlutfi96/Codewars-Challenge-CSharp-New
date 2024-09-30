using System;
using System.Linq;

public static class Kata
{
  public static string Remove(string s)
  {
    return string.Join(" ",s.Split(" ").Where(x=>!(x.Where(y=>y == '!').Count() == 1)));

    // Alternative
    // return string.Join(" ", s.Split(' ').Where(x => x.Count(c => c == '!') != 1));
  }

  public static void Main(){
    Console.WriteLine(Remove("Hi! Hi!! Hi!"));
  }
}