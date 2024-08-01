using System;

public class Kata
{
  public static string CatMouse(string x)
  {
    // Your code here...
    return x.Where(x=>x == '.').Count() <= 3 ? "Caught!" : "Escaped!";

    // Alternative
    // return x.Length > 5 ? "Escaped!" : "Caught!";
    // return Regex.IsMatch(x, "C.{0,3}m") ? "Caught!" : "Escaped!";
  }

  public static void Main(){
    Console.WriteLine(CatMouse("C..m"));
  }
}