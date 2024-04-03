// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
public static class StringExtensions
{
  public static bool IsUpperCase(this string text)
  {
    // your code here
    return text.ToUpper() == text;
  }
  public static void Main(){
    Console.WriteLine(IsUpperCase("hello I AM DONALD"));
    Console.WriteLine(IsUpperCase("HELLO I AM DONALD"));
  }
}
