// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
  public static bool CheckForFactor(int num, int factor)
  {
    // code here
    return num%factor == 0;
  }
  public static void Main(){
    Console.WriteLine(CheckForFactor(10,2));
  }
}