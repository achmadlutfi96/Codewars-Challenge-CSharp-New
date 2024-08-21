namespace NthRoot
{
  public class Kata
  {
    public static double FindRoot(double x, int n)
    {
       return Math.Pow(x, (1.0/n));
    }

    public static void Main(){
        Console.WriteLine(FindRoot(4, 2));
        Console.WriteLine(FindRoot(8,3));
        Console.WriteLine(FindRoot(256, 4));
        Console.WriteLine(FindRoot(9, 2));
        Console.WriteLine(FindRoot(6.25, 2));
    }
  }
}