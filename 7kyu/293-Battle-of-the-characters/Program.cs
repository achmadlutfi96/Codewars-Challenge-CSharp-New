using System.Linq;
public class Kata
{
  public static string Battle(string x, string y)
  {
    // Lets the battle begin!
    int a = x.Sum(i=>i-64);
    Console.WriteLine(a);
    int b = y.Sum(j=>j-64);
    Console.WriteLine(b);
    return a == b ? "Tie!": a > b ? x : y;

    // Alternative
    // return new[] {y, "Tie!", x}[x.Sum(c => c - 64).CompareTo(y.Sum(c => c - 64)) + 1];
  }

  public static void Main(){
    Console.WriteLine(Battle("FOUR", "FIVE"));
  }
}
