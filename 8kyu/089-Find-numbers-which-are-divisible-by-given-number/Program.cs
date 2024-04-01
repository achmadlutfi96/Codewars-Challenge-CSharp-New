// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Linq;

public class Kata
{
  public static int[] DivisibleBy(int[] numbers, int divisor)
  {
    return numbers.Where(n => n%divisor == 0).ToArray();
  }
  public static void Main(){
    foreach (var item in DivisibleBy(new int[]{1,2,3,4,5,6}, 2))
    {
        Console.WriteLine(item);
    }
  }
}
