using System;
using System.Linq;
public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    return cc.Length > 4 ?  string.Concat(Enumerable.Repeat("#", cc.Length-4)) + cc.Substring(cc.Length-4) : cc ;

    // Alternative
    // return cc.Substring(cc.Length < 4 ? 0 : cc.Length - 4).PadLeft(cc.Length, '#');
  }

  public static void Main(){
    Console.WriteLine(Maskify("4556364607935616"));
  }
}
