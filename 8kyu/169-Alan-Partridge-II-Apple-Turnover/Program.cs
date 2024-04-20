using System;
public class Kata
{
  public static string Apple(object n)
  {
    return Math.Pow(Convert.ToInt32(n), 2)  > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
  }

  public static void Main(){
    Console.WriteLine(Apple("50"));
  }
}