public class Kata
{
  public static int SumTriangularNumbers(int n)
  {
    if(n < 0){
        return 0;
    }
    int sum = 0, num = 0;
    for (int i = 1; i <= n ; i++){
        num += i;
        sum += num;
    }
    return sum;

    // Alternative
    // if (n <= 0)
    //   return 0;
  
    // /* The sum of the all triangular numbers up to the nth triangular
    //    number is the nth tetrahedral (triangular pyramidal) number.
       
    //    The formula for the n-th tetrahedral number is represented by
    //    the 3rd rising factorial of n divided by the factorial of 3 */
    // return (n * (n + 1) * (n + 2)) / 6;
  }

  public static void Main(){
    Console.WriteLine(SumTriangularNumbers(6));
  }
}