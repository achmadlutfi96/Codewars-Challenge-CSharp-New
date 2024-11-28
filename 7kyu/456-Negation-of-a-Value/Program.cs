public class Kata
{
  public static bool NegationValue(string str, bool value)
  {
    // your code here
    return str.Length%2 == 0 ? value : !value;
  }

  public static void Main()
  {
    Console.WriteLine(NegationValue("!!!", false));
  }
}