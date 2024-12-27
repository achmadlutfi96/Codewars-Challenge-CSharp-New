using System;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static string toInitials(string name)
    {
      return string.Join(" ",name.Split(" ").Select(x=>x[0]+"."));
    }

    public static void Main()
    {
        Console.WriteLine(toInitials("Tom Araya"));
    }
  }
}