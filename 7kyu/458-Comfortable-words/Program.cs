using System;

public class Kata
{
  public static bool ComfortableWord(string word)
  {
    string right = "yuiophjklnm";
    string left = "qwertasdfgzxcvb";
    
    for (int i = 1; i < word.Length; i++)
    {
        if(right.Contains(word[i-1]) == right.Contains(word[i]) || left.Contains(word[i-1]) == left.Contains(word[i])){
            return false;
        }
    }
    return true; // todo

    // Alternative
    // var s = string.Concat(word.Select(c => "yuiophjklnm".Contains(c) ? "R" : "L"));
    // return !(s.Contains("LL") || s.Contains("RR"));
  }

  public static void Main()
  {
    Console.WriteLine(ComfortableWord("their"));
    Console.WriteLine(ComfortableWord("leisure"));
  }
}