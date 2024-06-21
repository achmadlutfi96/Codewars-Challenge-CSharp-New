using System;
using System.Linq;
using System.Collections.Generic;

public class Kata 
{
  public static int GetNumber(string str) 
  {
    List<int> temp = new List<int>();
    for (int i = 0; i < str.Length-4; i++){
        temp.Add(Convert.ToInt32(str.Substring(i, 5)));
    }
    return temp.Max();

    // Alternative
    // return int.Parse(Enumerable.Range(0, s.Length - 4).Max(i => s.Substring(i, 5)));
  }

  public static void Main(){
    Console.WriteLine(GetNumber("731674765"));
  }
}