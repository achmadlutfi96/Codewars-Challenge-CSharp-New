using System.Linq;

public class Kata
{
  public static int[] GetEvenNumbers(int[] numbers)
  {
    // filter out the odd numbers
    return numbers.Where(x=>x%2 == 0).ToArray();
  }

  public static void Main(){
    foreach (var item in GetEvenNumbers(new int[] {12, 14, 15}))
    {
        Console.WriteLine(item.ToString());
    }
  }
}