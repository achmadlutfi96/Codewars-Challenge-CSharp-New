using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    return input.Where(s => char.ToLower(s) == 'x').Count() == input.Where(s => char.ToLower(s) == 'o').Count();//Code it!

    // Alternative
    // return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
  }

  public static void Main(){
    Console.WriteLine(XO("xxOo"));
  }
}