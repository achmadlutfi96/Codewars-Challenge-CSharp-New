using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Kata
{
  public static int SumOfIntegersInString(string s)
  {
    // List<int> res = new List<int>();
    // string digit = "0123456789";
    // string temp = "";
    // foreach (char c in s){
    //     if(digit.Contains(c)){
    //         temp += c;
    //         if(s.EndsWith(c)){
    //             res.Add(int.Parse(temp));
    //         }
    //     }else if(temp != ""){
    //         res.Add(int.Parse(temp));
    //         temp = "";
    //     }
    // }
    // return res.Sum();

    return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));

    // Alternative
    // return Regex.Split(s, "\\D").Where(x => x != "").Sum(int.Parse);
  }

  public static void Main(){
    // Console.WriteLine(SumOfIntegersInString("The Great Depression lasted from 1929 to 1939."));
    Console.WriteLine(SumOfIntegersInString("12.4"));
  }
}