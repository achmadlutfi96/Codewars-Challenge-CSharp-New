using System;
public class Kata
{
  public static string SayHello(string[] name, string city, string state)
  {
    // return $"Hello, {string.Join(' ', name)}! Welcome to {city}, {state}!";
    return string.Format("Hello, {0}! Welcome to {1}, {2}!", string.Join(' ', name), city, state);
  }
  public static void Main(){
    Console.WriteLine(SayHello(new string[] {"John", "Smith"}, "Phoenix", "Arizona"));
  }
}