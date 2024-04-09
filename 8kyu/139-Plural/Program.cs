public class Kata
{
  public static bool Plural(double n)
  {
    return !(n==1);
  }
  public static void Main(){
    Console.WriteLine(Plural(1));
  }
}