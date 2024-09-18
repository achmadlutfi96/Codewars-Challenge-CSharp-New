public class Kata
{
  public static int[] ExtraPerfect(int n)
  {
    //your code here
    return Enumerable.Range(1, n).Where(x=>Convert.ToString(x, 2).StartsWith("1") && Convert.ToString(x, 2).EndsWith("1")).ToArray();

    // Alternative
    //  return Enumerable.Range(1, n).Where(x => x % 2 != 0);
  }

  public static void Main(){
    Console.WriteLine(string.Join(",", ExtraPerfect(28)));
  }
}