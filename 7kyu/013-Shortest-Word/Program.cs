using System;
using System.Linq;
public class Kata
{
  public static int FindShort(string s)
  {
    return s.Split(" ").Select(v => v.Length).Min();

    // Alternative
    // return s.Split(' ').Min(x => x.Length);
  }

  public static void Main(){

    Console.WriteLine(FindShort("bitcoin take over the world maybe who knows perhaps"));
  }
}