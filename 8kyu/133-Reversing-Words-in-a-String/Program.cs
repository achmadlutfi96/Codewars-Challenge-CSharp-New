using System;
using System.Linq;
public class Kata
{
  public static string Reverse(string text)
  {
    return String.Join(" ",text.Split(" ").Reverse());
  }
  public static void Main(){
    Console.WriteLine(Reverse("Hello World"));
  }
}