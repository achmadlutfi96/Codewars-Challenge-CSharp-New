using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static IEnumerable<T> Every<T>(this IEnumerable<T> arr, int interval, int start)
  {
    // throw new NotImplementedException();
    return arr.Skip(start).Where((v,i)=> i%interval == 0);
  }

  public static IEnumerable<T> Every<T>(this IEnumerable<T> arr, int interval)
  {
    // throw new NotImplementedException();
    return arr.Where((v,i)=> i%interval == 0);
  }

  public static IEnumerable<T> Every<T>(this IEnumerable<T> arr)
  {
    // throw new NotImplementedException();
    return arr;
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ", new int []{0,1,2,3,4}.Every()));
    Console.WriteLine(string.Join(", ", new int []{0,1,2,3,4}.Every(1)));
    Console.WriteLine(string.Join(", ", new int []{0,1,2,3,4}.Every(2)));
  }
}