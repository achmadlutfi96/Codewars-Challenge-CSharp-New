using System;
using System.Linq;

public class Kata
{
  public static string BuildRowText(int index, char character)
  {
    // Do your magic :)
    return "|"+string.Join("|",Enumerable.Repeat(' ',9).Select((v,i)=>i==index ? character : v))+"|";
  }

  public static void Main()
  {
    Console.WriteLine(BuildRowText(2,'A'));
  }
}