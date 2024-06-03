using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    //Your code goes here!
    return n == 0 ? true : Math.Pow(Math.Ceiling(Math.Sqrt(n)), 2) == n ? true : false;

    // Alternative
    // return Math.Sqrt(n) % 1 == 0;
  }

  public static void Main(){
    Console.WriteLine(IsSquare(634129));
  }
}