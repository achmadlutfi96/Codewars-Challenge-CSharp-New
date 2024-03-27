// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
    if(numbers == null) return 0;
    if(numbers.Length == 0) return 0;
    Array.Sort(numbers);
    return numbers.Skip(1).SkipLast(1).Sum();
    // Alternative
    // return numbers == null || numbers.Length < 2 ? 0 : numbers.Sum() - numbers.Max() - numbers.Min();
  }
  public static void Main(){
    Console.WriteLine(Sum(new[] { 6, 2, 1, 8, 10}));
    Console.WriteLine(Sum(new[] { 6, 2, 1, 1, 8, 10}));
  }
}
