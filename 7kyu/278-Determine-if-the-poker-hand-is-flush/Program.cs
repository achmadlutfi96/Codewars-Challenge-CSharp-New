using System;
using System.Linq;

public class Kata
{
  public static bool CheckIfFlush(string[] cards)
  {
    //Write your code here
    
     return cards.All(x=>x.EndsWith("S")) || cards.All(x=>x.EndsWith("D")) || cards.All(x=>x.EndsWith("C")) || cards.All(x=>x.EndsWith("H"));

    //  Alternative
    // return cards.All(x => x.Last() == cards.First().Last())
  }

  public static void Main()
  {
    Console.WriteLine(CheckIfFlush(["10D", "QD", "7D", "KD", "5D"]));
  }
}