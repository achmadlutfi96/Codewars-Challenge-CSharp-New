using System;
public class Kata
{
  public static string Remove(string s)
  {
    //coding and coding....
    return $"{s.Replace("!","")}!";
  }

  public static void Main(){
    Console.WriteLine(Remove("Hi!!!"));
  }
}