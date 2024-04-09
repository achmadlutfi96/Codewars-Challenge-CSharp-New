using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static int binToDec(string s)
    {
        // int j = 0;
        // List<int> res = new List<int>();
        // for (int i = s.Length-1; i >= 0 ; i--)
        // {
        //     res.Add(s[i].Equals('1') ? (int) Math.Pow(2, j) : (int) 0);
        //     j++;
        // }
        // return res.Sum();
        // Alternative
        return Convert.ToInt32(s, 2);
    }
    public static void Main(){
        Console.WriteLine(binToDec("110"));
    }
  }
}