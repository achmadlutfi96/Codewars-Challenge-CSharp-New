using System.Linq;
public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    // code here
    return Enumerable.Range(1, m).Select(i => i * n).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", Multiples(3, 5)));
  }
}