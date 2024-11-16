using System.Collections.Generic;
public class Kata
{
  public static double[] AvgArray(double[][] arr)
  {
    List<double> res = new List<double>();
    for (int i = 0; i < arr[0].Length; i++){
        double num = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            num += arr[j][i];
        }
        res.Add(num/arr.Length);
    }
    return res.ToArray();

    // Alternative 
    // return arr[0].Select((d, i) => arr.Average(x => x[i])).ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join(",", AvgArray(new double[][] {new double[] {1, 2, 3, 4}, new double[] {5, 6, 7, 8}})));
  }
}