using System;

public static class Kata
{
  public static int CountRedBeads(int n)
  {
    // throw new NotImplementedException();
    return n > 0 ? (n-1)*2 : 0;

    // Alternative
    // return Math.Max(0, 2 * n - 2);
  }

  public static void Main(){
    Console.WriteLine(CountRedBeads(3));
  }
}