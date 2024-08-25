using System.Linq;
public class Kata
{
  public static int Average(int[] scores)
  {
    return (int) Math.Round(scores.Average(),MidpointRounding.AwayFromZero);
  }

  public static void Main(){
    Console.WriteLine(Average(new int[] { 49,3,5,300,7 }));
  }
}