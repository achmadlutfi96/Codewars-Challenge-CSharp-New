using System.Linq;
using System;
public class Kata
{
  public static object[] ArrayLowerCase(object[] arr)
  {
    return arr.Select(x=>x.GetType() == typeof(string) ? x.ToString().ToLower() : x).ToArray();

    // Alternative
    // return arr.Select(o => (o as string)?.ToLower() ?? o).ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ",ArrayLowerCase(new object[] { "Red", "Green" })));
  }
}