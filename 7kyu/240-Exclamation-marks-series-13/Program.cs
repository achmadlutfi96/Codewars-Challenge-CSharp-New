using System;
using System.Linq;

public class Kata
{
  public static int Product(string str)
  {
    return str.Where(x=>x.Equals('!')).Count() * str.Where(y=>y.Equals('?')).Count();

    // Alternative
    // return str.Count(c => c == '!') * str.Count(c => c == '?')
  }

  public static void Main(){
    Console.WriteLine(Product("!!???????!!!!!"));
  }
}