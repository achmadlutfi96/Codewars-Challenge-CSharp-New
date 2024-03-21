// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;
using System;
class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    // Your code here
    return array.Length != 0 ? array.Average() : 0;
    // Alternative
    // return array.DefaultIfEmpty().Average();
  }
  public static void Main(){
    Console.WriteLine(FindAverage(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 }));
    Console.WriteLine(FindAverage(new double[] {}));
  }
} 