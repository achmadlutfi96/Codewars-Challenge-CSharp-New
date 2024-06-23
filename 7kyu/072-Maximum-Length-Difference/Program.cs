using System;
using System.Linq;

public class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        // your code
         if(a1.Length == 0 || a2.Length == 0){
          return -1;
        }
        int s1Min = a1.Select(x=>x == string.Empty ? -1 : x.Length).Min(x=>x);
        int s2Min = a2.Select(x=>x == string.Empty ? -1 : x.Length).Min(x=>x);
        int s1Max = a1.Select(x=>x == string.Empty ? -1 : x.Length).Max(x=>x);
        int s2Max = a2.Select(x=>x == string.Empty ? -1 : x.Length).Max(x=>x);
        return Math.Max(Math.Abs(s1Max - s2Min) , Math.Abs(s2Max - s1Min));

        // Alternative
        // return !a1.Any() || !a2.Any() ? -1 : a1.Max(x => a2.Max(y => Math.Abs(x.Length - y.Length)));
    }

    public static void Main(){
        string[] s1 = new string[]{"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
        string[] s2 = new string[]{"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};
        Console.WriteLine(Mxdiflg(s1,s2));
    }
}