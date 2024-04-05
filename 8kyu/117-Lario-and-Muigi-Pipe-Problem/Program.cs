using System.Collections.Generic;
using System.Linq;

public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
  {
    //Good luck!
    return Enumerable.Range(numbers.First(), numbers.Last()-numbers.First()+1).ToList();
  }
  public static void Main(){
    foreach (var item in PipeFix(new List<int>{1,2,3,5,6,8,9}))
    {
        Console.WriteLine(item);
    }
    foreach (var item in PipeFix(new List<int>{6,9}))
    {
        Console.WriteLine(item);
    }
  }
}