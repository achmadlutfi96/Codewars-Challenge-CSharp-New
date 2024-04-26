public class Kata
{
  public static double SquareArea(double A)
  {
    return Math.Round(Math.Pow(4*A/(2*Math.PI),2),2);
  }

  public static void Main(){
    Console.WriteLine(SquareArea(2));
    Console.WriteLine(SquareArea(14.05));
  }
}