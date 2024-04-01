// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
  public static int GetAge(string inputString)
  {
    // return correct age (int). Happy coding :)
    return Int32.Parse(inputString[0].ToString());
    // Alternative
    // return (int)char.GetNumericValue(inputString[0]);
  }
  public static void Main(){
    Console.WriteLine(GetAge("3 years old"));
  }
}