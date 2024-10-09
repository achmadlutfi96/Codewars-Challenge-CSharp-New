using System;
using System.Linq;

public class Kata
{
    public static int[] getLargerNumbers(int[] a, int[] b)
    {
        return a.Select((v,i)=> v > b[i] ? v : b[i]).ToArray();

        // Alternative
        // return a.Zip(b, Max).ToArray();
    }

    public static void Main()
    {
        int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
        int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
        Console.WriteLine(string.Join(",", getLargerNumbers(arr1, arr2)));
    }
}