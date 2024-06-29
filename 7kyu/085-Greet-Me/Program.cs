using System;

public static class Kata
{
  public static string Greet(string name)
  {
    // throw new NotImplementedException();
    return $"Hello {name.ToUpper()[0]}{name.Substring(1).ToLower()}!";
  }

  public static void Main(){
    Console.WriteLine(Greet("JACK"));
  }
}