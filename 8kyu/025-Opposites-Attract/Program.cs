// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        //Moment of truth...
        return !(flower1%2 == flower2%2);
        // ALTERNATIVE
        // return flower1 % 2 != flower2 % 2 ;
    }

    public static void Main(){
        Console.WriteLine(lovefunc(1,4));
        Console.WriteLine(lovefunc(2,2));
    }
}
