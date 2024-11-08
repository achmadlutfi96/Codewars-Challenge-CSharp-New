using System;

public class Kata
{
  public static int NotVisibleCubes(int n)
  {
    // your code!
    return n > 2 ? (int)Math.Pow(n-2, 3) : 0;
  }

  public static void Main()
  {
    Console.WriteLine(NotVisibleCubes(3));
  }
}