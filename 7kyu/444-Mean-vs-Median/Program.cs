using System.Linq;
class Solution
{
  public static string MeanVsMedian(int[] numbers)
  {
    Array.Sort(numbers);
    int mean = (int)numbers.Average();
    int median = numbers[numbers.Length/2];
    return mean == median ? "same" : mean > median ? "mean" : "median";

    // Alternative
    // return numbers.Average().CompareTo(numbers.OrderBy(x => x).ToArray()[numbers.Length / 2]) switch
    // {
    //     1 => "mean",
    //     -1 => "median",
    //     _ => "same"
    // };
  }

  public static void Main()
  {
    Console.WriteLine(MeanVsMedian(new int[] {1, 1, 1}));
    Console.WriteLine(MeanVsMedian(new int[] {1, 2, 37}));
    Console.WriteLine(MeanVsMedian(new int[] {7, 14, -70}));
  }
}