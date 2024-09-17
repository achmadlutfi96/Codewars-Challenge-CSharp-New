public class Kata
{
  public static string Broken(string x)
  {
    return string.Concat(x.Select(b=> b == '0' ? '1' : '0'));
  }

  public static void Main(){
    Console.WriteLine(Broken("100010"));
  }
}