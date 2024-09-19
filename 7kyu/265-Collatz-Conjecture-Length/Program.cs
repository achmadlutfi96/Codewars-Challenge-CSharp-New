public class Kata
{
  public static int Collatz(int n)
  {
    // your code here
    int result = 1;
    do{
        n = n%2 != 0 ? n*3+1 : n/2;
        result++; 
    }while(!(n==1));
    return result;
  }

  public static void Main(){
    Console.WriteLine(Collatz(20));
  }
}