using System;
using System.Linq;
public class Kata
{
  public static bool[] NumberProperty(int n)
  {
    bool prime = n > 0 ? Enumerable.Range(1,n).Where(v=>n%v == 0).Count() < 3 : false;
    bool even = n%2 == 0;
    bool m10 = n%10 == 0;
    return new bool[] {prime, even, m10};
  }
  
  public static void Main(){
    Console.WriteLine(string.Join(", ", NumberProperty(-10)));
    Console.WriteLine(string.Join(", ", NumberProperty(2)));
    Console.WriteLine(string.Join(", ", NumberProperty(120)));
    Console.WriteLine(string.Join(", ", NumberProperty(125)));
  }
}