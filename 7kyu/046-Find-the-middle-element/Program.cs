using System;
using System.Linq;

public class Kata
{
  public static int Gimme(double[] inputArray)
  {
    // Implement this function
    double[] outputArray  = new double[inputArray.Length];
    Array.Copy(inputArray, outputArray, inputArray.Length);
    Array.Sort(outputArray);
    return Array.IndexOf(inputArray, outputArray[1]);

    // Alternative 1
    // return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ToArray()[1]);
    // Alternative 2
    // return inputArray.ToList().IndexOf(inputArray.OrderBy(d => d).ElementAt(1));
  }

  public static void Main(){
    Console.WriteLine(Gimme(new double[] {2, 3, 1}));
  }
}