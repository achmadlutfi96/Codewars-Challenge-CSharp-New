using System;
using System.Numerics;

public static class Kata
{
  public static bool PowerOfTwo(int n)
  {
    //Math --> Magic
    return n > 0 ? Math.Pow(2, Math.Ceiling(Math.Log2(n))) == n : false;

    // Alternative 1
    // return new BigInteger(n).IsPowerOfTwo;
    // Alternative 2
    // return BitOperations.IsPow2(n);
  }

  public static void Main(){
    Console.WriteLine(PowerOfTwo(333));
  }
}