public class Kata
{
  public static int Nthterm(int first, int n, int c)
  {
    // Write your code here
    return n*c+first;
  }

  public static void Main()
  {
    Console.WriteLine(Nthterm(-50, 10, 20));
  }
}