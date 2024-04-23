using System;
using System.Linq;
public class Kata
{
  public static string PrintArray(object[] array)
  {
    return string.Join(",",array.Select(x=>x is Object[]?PrintArray(x as object[]):x));
    //Atau
    // return string.Join(",", array.Select(a => a.GetType().IsArray ? string.Join(",", (object[])a) : a));
  }

  public static void Main(){
    Console.WriteLine(PrintArray(new object[] { 2, 4, 5, 2 }));
    Console.WriteLine(PrintArray(new object[]{new object[]{"hello","this","is","an","array!"}, new object[]{"a","b","c","d","e!"}}));
  }
}