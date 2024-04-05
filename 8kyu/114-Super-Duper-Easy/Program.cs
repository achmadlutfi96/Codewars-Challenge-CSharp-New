using System;

public class Kata
{
  public static string Problem(String a)
  {
    //magic code
    try {
        decimal i = Convert.ToDecimal(a);
        return ((int)(i*50+6)).ToString();
    }catch(FormatException){
        return "Error";
    }

    // Alternative
    // return double.TryParse(a, out var n) ? $"{n * 50 + 6}" : "Error";
  }
  public static void Main(){
    Console.WriteLine(Problem("hello"));
    Console.WriteLine(Problem("1"));
  }
}