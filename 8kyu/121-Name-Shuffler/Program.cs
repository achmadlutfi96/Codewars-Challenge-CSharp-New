using System;
using System.Linq;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    //your code here...
    return String.Join(" ", str.Split(' ').Reverse());
  }
  public static void Main(string[] args){
    Console.WriteLine(NameShuffler("john McClane"));
  }
}