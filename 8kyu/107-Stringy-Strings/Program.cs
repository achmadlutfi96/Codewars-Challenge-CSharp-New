using System.Linq;
public class Kata
{
  public static string Stringy(int size)
  {
    // your code here
     return string.Join("", Enumerable.Range(1, size).Select(i => i%2==1 ? '1' : '0'));
     // Alternative
     // return string.Join("", Enumerable.Range(0, size).Select(x => (x + 1) % 2));
     // return string.Concat(Enumerable.Range(0, size).Select( x => x % 2 == 0 ? "1" : "0"));
  }
  public static void Main(){
    Console.WriteLine(Stringy(10));
  }
}