using System.Collections.Generic;

public class Kata
{
  public static int[] GenerateRange(int min, int max, int step)
  {
    // your code goes here
    // return Enumerable.Range(0, (max-min)/step + 1).Select(x => min + x*step).ToArray();
    List<int> numbers = new List<int>();
    for (int i = min; i <= max; i+=step)
    {
        numbers.Add(i);
    }
    return numbers.ToArray();
  }
  public static void Main(){
    foreach(var item in GenerateRange(-10, 1, 1)){
        Console.WriteLine(item);
    }
  }
}