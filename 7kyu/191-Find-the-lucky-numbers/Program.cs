public class Kata
{
  public static int[] FilterLucky(int[] x)
  {
    return x.Where(x=>x.ToString().Contains('7')).ToArray();

    // Alternative 
    // return Array.FindAll(x, m => $"{m}".Contains('7'));
  }

  public static void Main(){
    Console.WriteLine(string.Join(",",FilterLucky(new int[] {1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17})));
  }
}