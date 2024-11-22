using System;
using System.Linq;
using System.Numerics;

public class Kata
{
    public static int GetLastDigit(int index)
    {
        // Your code here
        int a = 0, b = 1;

        for (int i = 0; i < index; ++i)
        {
            b = a + b;
            a = b - a;
            b %= 10;
        }

        return a;
    }

    public static void Main()
    {
        Console.WriteLine(GetLastDigit(15));
        Console.WriteLine(GetLastDigit(300));
    }
}
