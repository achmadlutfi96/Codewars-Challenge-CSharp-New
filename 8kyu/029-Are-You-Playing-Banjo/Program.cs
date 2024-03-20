// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    //Implement me
    return name.ToLower().StartsWith('r')? $"{name} plays banjo" : $"{name} does not play banjo";
  }

  public static void Main(){
    Console.WriteLine(AreYouPlayingBanjo("Martin"));
    Console.WriteLine(AreYouPlayingBanjo("Rikke"));
  }
}
