// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Linq;

public class Kata
{
  public static int[] Maps(int[] x)
  {
    return x.Select(i => i+i).ToArray(); // hasil dari select adalah kelas enumerable maka harus diconvert ke array
  }
  public static void Main(){
    foreach (var item in Maps(new [] { 1, 2, 3 }))
    {
        Console.WriteLine(item);
    }
    
  }
}
