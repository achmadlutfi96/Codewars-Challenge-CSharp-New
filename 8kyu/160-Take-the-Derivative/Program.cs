public class Kata
{
  public static string Derive(double coefficient, double exponent)
  {
    return $"{coefficient*exponent}x^{exponent-1}";
  }

  public static void Main(){
    Console.WriteLine(Derive(7, 8));
  }
}