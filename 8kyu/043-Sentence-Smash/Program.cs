// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;

public class Kata
{
  public static string Smash(string[] words)
  {
    // Smash words
    return String.Join(' ', words);
  }
  public static void Main(){
    Console.WriteLine(Smash(new string[] {"hello", "world"}));
  }
}
