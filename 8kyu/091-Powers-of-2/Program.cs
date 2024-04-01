// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Numerics;
using System.Linq;
using System;

public class Kata
{
  public static BigInteger[] PowersOfTwo(int n)
  {

    // return new BigInteger[0];
    return Enumerable.Range(0, n+1).Select(i => (BigInteger) Math.Pow(2, i)).ToArray();
  }
  public static void Main(){
    foreach (var item in PowersOfTwo(4))
    {
        Console.WriteLine(item);
    }
  }
}