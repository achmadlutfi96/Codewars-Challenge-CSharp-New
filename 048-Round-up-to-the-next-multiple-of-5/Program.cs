using System;

public class Kata
{
  public static int RoundToNext5(int n)
  {
    //Your code goes here...
    return (int) Math.Ceiling((double)n/5)*5;
  }

  public static void Main(){
    Console.WriteLine(RoundToNext5(12));
  }
}