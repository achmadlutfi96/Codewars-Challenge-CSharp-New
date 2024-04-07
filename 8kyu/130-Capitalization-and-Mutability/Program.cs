using System;
public class Kata
{
  public static string CapitalizeWord(string word)
  {
    string res = "";
    res += word[0].ToString().ToUpper()[0];
    res += word.Substring(1);
    return res;

    // Alternative
    // return char.ToUpper(word[0]) + word.Substring(1);
    // return char.ToUpper(word[0]) + word[1..];
  }
  public static void Main(){
    Console.WriteLine(CapitalizeWord("word"));
  }
}