using System;

public class MaxRotate
{

    public static long MaxRot(long n)
    {
        // your code
        string num = n.ToString();

        for (int i = 0; i < num.Length - 1; i++) {
            num = num.Substring(0, i) + 
                    num.Substring(i + 1) + 
                    num.ElementAt(i);
            
            if (long.Parse(num) > n) {
                n = long.Parse(num);
            }
        }
        return n;
    }

    public static void Main()
    {
        Console.WriteLine(MaxRot(38458215));
    }
}