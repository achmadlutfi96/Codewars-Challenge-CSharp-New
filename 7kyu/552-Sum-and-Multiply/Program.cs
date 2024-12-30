public class Kata
{
  public static int[] SumAndMultiply(int sum, int multiply)
  {
    // write your code here
    int[] res = new int[2];
    for (int i = 0; i <= sum; i++)
    {
        for (int j = 0; j <= sum; j++)
        {
            if((i+j == sum)&&(i*j == multiply))
            {
                res[0] = i;
                res[1] = j;
                return res;
            }
        }
    }
    return null;

    // Alternative
    // for (var i = 0; i <= sum / 2; ++i)
    // {
    //   if ((sum - i) * i == multiply) return new[] {i, sum - i};
    // }
    // return null;
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(", ", SumAndMultiply(12,32)));
  }
}