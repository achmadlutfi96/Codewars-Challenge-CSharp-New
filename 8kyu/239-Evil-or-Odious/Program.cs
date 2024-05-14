using System;
using System.Linq;
public class Kata
{
  public static string Evil(int n)
  {
    return (Convert.ToString(n, 2)).Count(b=>b.Equals('1'))%2 == 1 ? "It's Odious!" : "It's Evil!";
    // return Convert.ToString(n, 2);
  }

  public static void Main(){
    Console.WriteLine(Evil(1));
    Console.WriteLine(Evil(2));
    Console.WriteLine(Evil(3));
  }
}