// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Solution
{
  public class TwiceAsOldSolution
  {
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
      // Add you code here.
      return Math.Abs(dadYears-(sonYears*2));
    }

    public static void Main(){
        Console.WriteLine(TwiceAsOld(30, 0));
        Console.WriteLine(TwiceAsOld(30, 7));
    }
  }
}
