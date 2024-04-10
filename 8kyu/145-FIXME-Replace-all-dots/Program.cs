using System.Text.RegularExpressions;

public class Kata
{
  public static string ReplaceDots(string str)
  {
    // return new Regex(".").Replace(str, "-");
    return str.Replace('.', '-');
    // return new Regex(@"\.").Replace(str, "-");
  }

  public static void Main(){
    Console.WriteLine(ReplaceDots("one.two.three"));
  }
}