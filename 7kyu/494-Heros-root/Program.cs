using System;

public class IntSqRoot 
{
	public static long IntRac(long n, long guess)  
	{
		// your code
        long x = guess;
        long res = 1;
        do{
            x = (x + n / x) / 2;
            res++;
        }while(x != (long) Math.Sqrt(n));
        return res;
	}

    public static void Main()
    {
        Console.WriteLine(IntRac(25,1));
        Console.WriteLine(IntRac(125348, 300));
    }
}