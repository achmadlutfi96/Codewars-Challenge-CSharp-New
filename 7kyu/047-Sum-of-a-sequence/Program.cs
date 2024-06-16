using System;
using System.Linq;

public static class Kata
{
  public static int SequenceSum(int start, int end, int step)
  {
    int sum = 0;
    for (int i = start; i <= end; i+=step){
        sum += i;
    }
    return sum;

    // Alternative
    // return start > end ? 0 : Enumerable.Repeat(start, (end - start) / step + 1).Select((x, index) => x + step * index).Sum();
  }

  public static void Main(){
    Console.WriteLine(SequenceSum(2, 6, 2));
  }
}