using System.Linq;

public class Kata
{
  public static int LargestPairSum(int[] numbers)
  {
    // TODO: Write your code here
    return numbers.OrderBy(x=>x).TakeLast(2).Sum();
  }

  public static void Main(){
    Console.WriteLine(LargestPairSum(new int[] {-8, -8, -16, -18, -19}));
  }
}