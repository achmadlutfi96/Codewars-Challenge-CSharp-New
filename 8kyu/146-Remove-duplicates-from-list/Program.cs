using System;

namespace Solution
{
  public static class Program
  {
    public static int[] distinct(int[] a)
    {
      return a.Distinct().ToArray();
    }

    public static void Main(string[] args){
        foreach (var item in distinct(new int[]{1,1,2}))
        {
            Console.WriteLine(item);
        }
    }
  }
}