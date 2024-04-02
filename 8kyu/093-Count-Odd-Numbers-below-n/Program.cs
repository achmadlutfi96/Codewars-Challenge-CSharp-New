// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public static class Kata
{
  public static ulong OddCount(ulong n)
  {
    // throw new NotImplementedException();
    return n/2;
  }
  public static void Main(){
    Console.WriteLine(OddCount(15023));
    Console.WriteLine(OddCount(15));
  }
}
