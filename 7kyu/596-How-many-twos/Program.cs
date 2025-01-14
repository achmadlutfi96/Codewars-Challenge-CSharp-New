public class Kata
{
  public static int TwoCount(int n)
  {
    // Your code 
    int count = 0; 
    while (n % 2 == 0) { 
        count++; 
        n /= 2; 
    } 
    return count;

    // Alternative
    // return (int) Math.Log(n & -n, 2);
  }
}