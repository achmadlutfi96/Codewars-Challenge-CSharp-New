using System;
using System.Linq;
public class Kata
{
    public static int[] Flip(char dir, int[] arr)
    {
        Array.Sort(arr);
        if(dir == 'L') Array.Reverse(arr);        
        return arr;

        // Alternative
        // return dir == 'R' ? arr.OrderBy(x=>x).ToArray() : arr.OrderByDescending(x=>x).ToArray();
    }
    public static void Main(){
        foreach (var item in Flip('R', new int[]{ 3,2,1,2 }))
        {
            Console.WriteLine(item);
        }
    }
}