using System;
public class Solution
{
    public static string IsSmooth(long n)
    {
        int[] prime = new int[] { 2, 3, 5, 7 };
        int i = 0;
        while (n != 1)
        {
            if (n % prime[i] == 0)
            {
                n /= prime[i];
            }
            else
            {
                i++;
                if (i == prime.Length)
                {
                    break;
                }
            }
        }

        if (i == 0)
        {
            return "power of 2";
        }
        if (i == 1)
        {
            return "3-smooth";
        }
        if (i == 2)
        {
            return "Hamming number";
        }
        if (i == 3)
        {
            return "humble number";
        }
        return "non-smoooth"; //your code here

        // Alternative
        // long i = 1;
        // while (n > 1)
        // {
        //     i++;
        //     while (n % i == 0) n /= i;
        // }

        // return i switch
        // {
        //     2 => "power of 2",
        //     3 => "3-smooth",
        //     5 => "Hamming number",
        //     7 => "humble number",
        //     _ => "non-smooth"
        // };
    }

    public static void Main()
    {
        Console.WriteLine(IsSmooth(16));
        Console.WriteLine(IsSmooth(36));
        Console.WriteLine(IsSmooth(60));
        Console.WriteLine(IsSmooth(98));
        Console.WriteLine(IsSmooth(111));
    }
}