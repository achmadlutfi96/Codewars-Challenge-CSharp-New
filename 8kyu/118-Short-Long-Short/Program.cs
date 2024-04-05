public class ShortLongShort
{
  public static string Solution(string a, string b)
  {
    return a.Length > b.Length ? b+a+b : a+b+a;
  }
  public static void Main(){
    Console.WriteLine(Solution("1", "22"));
  }
}