public class Kata
{
  public static double Round(double n)
  {
    return Math.Round(n,2);

    // Alternative 1
    // double res = ((int)((n + 0.005)* 100));
    //   return res / 100;

    
  }

  public static void Main()
  {
    Console.WriteLine(Round(5.678));
  }
}