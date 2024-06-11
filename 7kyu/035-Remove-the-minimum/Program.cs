using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    // Good Luck!
    if (numbers.Count == 0){
        return new List<int>();
    }
    List<int> res = new List<int>();
    foreach (var item in numbers)
    {
        res.Add(item);
    }
    res.Remove(numbers.Min());
    return res;

    // Alternative
    // numbers.Remove(numbers.DefaultIfEmpty().Min());
    // return numbers;
  }

  public static void Main(){
    foreach (var item in RemoveSmallest(new List<int>{5, 3, 2, 1, 4}))
    {
        Console.WriteLine(item);
    }
  }
}