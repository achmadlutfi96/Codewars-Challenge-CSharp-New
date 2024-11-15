using System;

public class Kata
{
  public static bool IsPronic(int n)
  {
    // Happy Coding ^_^
    int i = (int)Math.Sqrt(n);
    return i*(i+1) == n;

    // Alternative
    // return Math.Sqrt(1 + 4 * n) % 1 == 0;
  }

  public static void Main()
  {
    Console.WriteLine(IsPronic(2));
    Console.WriteLine(IsPronic(3));
  }
}