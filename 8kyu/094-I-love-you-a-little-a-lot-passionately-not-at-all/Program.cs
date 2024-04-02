// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    // your code
    return (nb_petals%6) switch{
        0 => "not at all",
        1 => "I love you",
        2 => "a little",
        3 => "a lot",
        4 => "passionately",
        _ => "madly"
    };
  }
  public static void Main(){
    Console.WriteLine(HowMuchILoveYou(7));
  }
}
