using System;
using System.Linq;

public class MinMax 
{
    public static int[] minMax(int[] lst) 
    {
        // your code
        return [lst.Min(), lst.Max()];
    }

    public static void Main(){
        foreach(var n in minMax(new int[] {1, 2, 5, -1, 12, 20})){
            Console.WriteLine(n);
        }
    }
}