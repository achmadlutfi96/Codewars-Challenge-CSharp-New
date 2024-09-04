using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static string UnscrambleEggs(string word)
  {
    //coding is feggunegg
    return word.Replace("egg", "");
  }
  
  public static void Main(){
    Console.WriteLine(UnscrambleEggs("ceggodegge heggeregge"));
  }
}