public class Kata 
{
  public static int BreakChocolate(int n, int m) 
  {
    //a miracle occurs...
    return n>0 && m>0 ? n*m-1 : 0;
  }

  public static void Main(){
    Console.WriteLine(BreakChocolate(5, 5));
  }
}