public class Kata
{
  public static int Remainder(int D, int d)
  {  
    // Your Code Goes Here
    return D-(D/d*d); 
  }

  public static void Main()
  {
    Console.WriteLine(Remainder(34,7));
  }
}