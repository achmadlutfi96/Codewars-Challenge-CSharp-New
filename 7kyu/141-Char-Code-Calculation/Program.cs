using System;
using System.Linq;

public class Kata
{
  public static Int32 Calc(String s)
  {
    string total1 = string.Concat(s.Select(x=>((int)x).ToString()));
    string total2 = total1.Replace("7", "1");
    return total1.Sum(a=>(int)char.GetNumericValue(a))-total2.Sum(b=>(int)char.GetNumericValue(b));

    // Alternative
    // return string.Concat(s.Select(x => (int) x)).Count(x => x == '7') * 6;
  }

  public static void Main(){
    Console.WriteLine(Calc("ABC"));
    Console.WriteLine(Calc("sUuPmNnnJOOCAGOuyzmcHQGJhXHYgZLY"));
  }
}