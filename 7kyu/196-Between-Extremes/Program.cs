using System.Linq;
public class Kata
{
  public static int BetweenExtremes(int[] numbers)
  {
    // your code goes here
    return numbers.Max() - numbers.Min();
  }

  public static void Main(){
    Console.WriteLine(BetweenExtremes(new int[]{21, 34, 54, 43, 26, 12}));
  }
}