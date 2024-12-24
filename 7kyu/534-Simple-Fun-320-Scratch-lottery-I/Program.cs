using System;
using System.Linq;
public class Kata
{
  public static int Scratch(string[] lottery)
  {
    //coding and coding..
    return lottery.Select(x=>x.Contains(string.Join(" ",Enumerable.Repeat(x.Split(" ")[0],3))) ? Convert.ToInt32(x.Split(" ")[3]) : 0).Sum();

    // Alternative
    // return lottery.Sum(s => s.Split().Distinct().Count() == 2 ? int.Parse(s.Split().Last()) : 0);
  }

  public static void Main()
  {
    Console.WriteLine(Scratch(new string[]
        {
          "tiger tiger tiger 100",
          "rabbit dragon snake 100",
          "rat ox pig 1000",
          "dog cock sheep 10",
          "horse monkey rat 5",
          "dog dog dog 1000"
        }));
  }
}