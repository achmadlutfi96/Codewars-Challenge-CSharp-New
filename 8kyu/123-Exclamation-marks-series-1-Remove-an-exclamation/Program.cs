using System;

public class Kata
{
  public static string Remove(string s)
  {
    //coding and coding....
    return s.EndsWith('!') ? s.Substring(0, s.Length - 1) : s;
    // Alternative
    // return s.EndsWith("!") ? s.Remove(s.Length-1) : s;
  }
  public static void Main(){
    Console.WriteLine(Remove("Hi!"));
    Console.WriteLine(Remove("Hi!!!"));
    Console.WriteLine(Remove("Hi"));
  }
}