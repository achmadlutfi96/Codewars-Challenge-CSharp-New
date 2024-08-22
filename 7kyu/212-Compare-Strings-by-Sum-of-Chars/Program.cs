using System;
using System.Linq;

public static class Kata
{
  public static bool Compare(string s1 = "", string s2 = "")
  { 

    int GetSum(string s) => s.All(char.IsLetter) ? s.Sum(c => (int) char.ToUpper(c)) : 0;
    return GetSum(s1 ?? "") == GetSum(s2 ?? "");
  }

  public static void Main(){
    Console.WriteLine(Compare("AD", "BC"));
    Console.WriteLine(Compare("AD", "DD"));
    Console.WriteLine(Compare("##", "1176"));
    Console.WriteLine(Compare(null, null));
  }
}