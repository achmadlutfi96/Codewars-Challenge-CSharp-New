// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Solution {
  using System;

  public class Solution
  {
    public static string[] StringToArray(string str)
    {
      // code code code
      return str.Split(' ');
    }
    public static void Main(){
        foreach (var item in StringToArray("Robin Singh"))
        {
            Console.WriteLine(item);
        }
        
    }
  }
  
}
