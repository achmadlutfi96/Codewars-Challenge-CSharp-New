using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static List<int> MultipleOfIndex(List<int> xs)
  {
    // throw new NotImplementedException();
    return xs.Where((v, i)=> v == 0 || (i != 0 && v%i == 0)).ToList();
  }

  public static void Main(){
    foreach (var item in MultipleOfIndex(new List<int> {22, -6, 32, 82, 9, 25}))
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine("\n");
    foreach (var item in MultipleOfIndex(new List<int> {68, -1, 1, -7, 10, 10}))
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine("\n");
    foreach (var item in MultipleOfIndex(new List<int> {11, -11}))
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine("\n");
    foreach (var item in MultipleOfIndex(new List<int> {0, 2, 3, 6, 9}))
    {
        Console.Write($"{item}, ");
    }
  }
}