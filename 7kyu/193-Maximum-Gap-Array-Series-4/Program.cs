using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static int MaxGap(int[] numbers)
  {
    // throw new NotImplementedException();
    List<int> gap = new List<int>();
    Array.Sort(numbers);
    for(int i = 0; i < numbers.Length-1; i++){
        gap.Add(Math.Abs(numbers[i+1]-numbers[i]));        
    }
    
    return gap.Max();

    // Alternative 1
    // Array.Sort(numbers);
    // return numbers.Zip(numbers.Skip(1), (a, b) => b - a).Max();

    // Alternative 2
    // return numbers
    //   .OrderBy(i => i)
    //   .Skip(1)
    //   .Zip(numbers.OrderBy(i => i), (a, b) => Math.Abs(b - a))
    //   .Max();
  }
  public static void Main(){
    Console.WriteLine(MaxGap(new int[] { 13, 10, 2, 9, 5 }));
  }
}