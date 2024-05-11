using System.Linq;
public class Kata
{
  public static string DrawStairs(int n)
  {
    // Happy coding ;)
    return string.Join("\n", Enumerable.Repeat("I", n).Select((v,i)=>string.Concat(Enumerable.Repeat(" ",i))+v).ToArray());

    // Alternative 1
    // return string.Join('\n', Enumerable.Range(1, n).Select("I".PadLeft));

    // Alternative 2
    // return string.Join("\n ", Enumerable.Repeat("I", n).Select((s, i) => s.PadLeft(i)));
  }

  public static void Main(){
    Console.WriteLine(DrawStairs(3));
  }
}