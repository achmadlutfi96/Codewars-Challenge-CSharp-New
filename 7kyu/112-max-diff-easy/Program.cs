public class Kata
{
  public static int MaxDiff(int[] lst)
  {
    return lst.Length > 1 ? lst.Max()-lst.Min() : 0;
  }

  public static void Main(){
    Console.WriteLine(MaxDiff(new[]{ 0, 1, 2, 3, 4, 5, 6 }));
  }
}