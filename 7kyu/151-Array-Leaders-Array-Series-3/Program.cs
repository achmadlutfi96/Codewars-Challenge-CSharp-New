using System;
using System.Linq;

public static class Kata
{
  public static int[] ArrayLeaders(int[] numbers)
  {
    // throw new NotImplementedException();
    return numbers.Where((x,i)=>x > numbers.Skip(i+1).Sum()).ToArray();
  }

  public static void Main(){
    Console.WriteLine(string.Join(',',ArrayLeaders(new int[] { 16, 17, 4, 3, 5, 2 })));
  }
}