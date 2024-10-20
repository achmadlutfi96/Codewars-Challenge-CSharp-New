using System;

public class Kata
{
    public static int Divisions(int n, int divisor)
    {
        int t = 0;
        while(n/divisor > 0){
            n = n/divisor;
            t++;
        }
        return t;

        // Alternative
        // return (int)Math.Log(n, divisor);
    }

    public static void Main()
    {
        Console.WriteLine(Divisions(100,2));
    }
}