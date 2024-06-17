using System.Linq;
public class Kata
{
  public static bool SmallEnough(int[] a, int limit)
  {
    return !a.Any(x=>x > limit);

    // Alternative
    // return Array.TrueForAll(a, x => x <= limit);
  }

  public static void Main(){
    Console.WriteLine(SmallEnough(new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100));
  }
}