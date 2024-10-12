using System.Text.RegularExpressions;

public class Kata
{
  public static string Remove(string s)
  {
    //coding and coding....
    return Regex.Replace(s, "(?!!*$)!", "");
  }

  public static void Main(){
    Console.WriteLine(Remove("Hi! Hi!"));
  }
}