using System;
public class Kata
{
  public static long FindNextSquare(long num)
  {
    long n = (long) Math.Ceiling(Math.Sqrt(num));
    return  n*n == num ? (n+1)*(n+1) : -1;
  }

  public static void Main(){
    Console.WriteLine(FindNextSquare(431800368986044969));
  }
}