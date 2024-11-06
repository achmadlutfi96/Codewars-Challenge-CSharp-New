using System.Collections.Generic;

public class Kata
{
    public static int[] Climb(int n)
    {
        Stack<int> res = new Stack<int>();
        while(n > 0){
            res.Push(n);
            n /= 2;
        }
        return res.ToArray();

        // Alternative
        // return new int[(int) Math.Log(n, 2)].Select(_ => n /= 2).Prepend(n).Reverse().ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(",", Climb(10)));
    }
}