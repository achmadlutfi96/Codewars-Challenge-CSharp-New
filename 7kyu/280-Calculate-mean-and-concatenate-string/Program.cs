using System;
using System.Linq;
public class Kata
{
  public static object[] Mean(char[] lst)
  {
    return new object[]{lst.Where(x=>char.IsNumber(x)).Average(x=>char.GetNumericValue(x)), string.Concat(lst.Where(x=>char.IsLetter(x)))};

    // Alternative
    // return new object[] {lst.Where(char.IsNumber).Average(c => c - 48), lst.Where(char.IsLetter)};
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", Mean(new [] { 'u', '6', 'd', '1', 'i', 'w', '6', 's', 't', '4', 'a', '6', 'g', '1', '2', 'w', '8', 'o', '2', '0' })));
  }
}