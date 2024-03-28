// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    // ...
    return (int) marks.Average();
  }
  public static void Main(){
    Console.WriteLine(GetAverage(new int[]{5,10}));
  }
}
