using System.Linq;
public class Kata
{
  public static bool OnlyOne(params bool[] flags)
  {
    return flags.Count(x=>x) == 1;
  }

  public static void Main()
  {
    Console.WriteLine(OnlyOne(true, false));
  }
}