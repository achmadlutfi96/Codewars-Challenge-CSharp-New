using System;
using System.Linq;

namespace Code
{
  public class Unique
  {
    public static bool HasUniqueChars(string str)
    {
        //TODO
        return str.Distinct().Count() == str.Length;
    }

    public static void Main(){
        Console.WriteLine(HasUniqueChars("abcdef"));
        Console.WriteLine(HasUniqueChars("aba"));
    }
  }
}