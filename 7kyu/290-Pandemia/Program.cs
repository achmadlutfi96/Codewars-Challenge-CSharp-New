using System;
using System.Linq;

public class Kata 
{
  public static double infected(string s)
  {
    //your code here
    if (s.All(x=>x == 'X')){
        return 0.0;
    }
    return (double) 100*s.Split("X").Where(x=>x.Contains("1")).Select(y=>y.Length).Sum()/s.Split("X").Select(x=>x.Length).Sum();

    // Alternative
    // return 100d * s.Split('X').Sum(x => x.Contains('1') ? x.Length : 0) / Math.Max(s.Count(char.IsNumber), 1);
  }

  public static void Main(){
    Console.WriteLine(infected("01000000X000X011X0X"));
  }
}