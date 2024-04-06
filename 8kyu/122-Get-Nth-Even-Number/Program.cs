public class Kata
{
  public static int NthEven(int n)
  {
    //Your code
    return n*2-2;
    // Altenative
    // return 2 * (n - 1);
  }
  public static void Main(){
    Console.WriteLine(NthEven(3));
  }
}