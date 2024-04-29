using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
public class Kata
{
  public static string Remove(string s, int n)
  {
    //coding and coding....
    List<char> lists = new List<char>();
    for (int i = 0; i < s.Length; i++)
    {
        if(s[i] == '!' && n > 0){
            n--;
            continue;
        }
        lists.Add(s[i]);
    }
    return string.Concat(lists);

    // Alternative 1
    // return String.Concat(s.Where(x => !(x == '!' && 0 < n--)))
    
    // Alternative 2
    // new Regex("!").Replace(s, "", n);
  }

  public static void Main(){
    Console.WriteLine(Remove("!!!Hi !!hi!!! !hi", 5));
  }
}