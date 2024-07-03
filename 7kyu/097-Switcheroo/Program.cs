using System.Linq;
public class Kata
{
  public static string Switcheroo(string x)
  {
    return string.Concat(x.Select(c=>c.Equals('b') ? 'a' : c.Equals('a') ? 'b' : c).ToArray());

    // Alternative
    // return x.Replace("a","d").Replace("b","a").Replace("d","b");
  }

  public static void Main(){
    Console.WriteLine(Switcheroo("bbbacccabbb"));
  }
}