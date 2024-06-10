using System;
using System.Linq;

public static class Kata
{
  public static string ReverseWords(string str)
  {
		//Write your code here
        return string.Join(" ", str.Split(" ").Select(x=>string.Concat(x.Reverse())));

        // Alternative
        // return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
  }

  public static void Main(){
    Console.WriteLine(ReverseWords("This is an example!"));
  }
}