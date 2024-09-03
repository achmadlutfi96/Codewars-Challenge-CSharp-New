using System;
using System.Linq;

namespace Codewars {
  public static class KataChallenge {
    public static bool IsDivisible(params int[] numbers)
    {
       //Start coding!!
       return numbers.All(x=>numbers[0]%x == 0);
    }

    public static void Main(){
        Console.WriteLine(IsDivisible(12, 3, 4));
    }
  }
}