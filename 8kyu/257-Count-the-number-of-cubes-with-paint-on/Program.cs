using System;

public static class Kata
{
    public static int CountSquares(int cuts)
    {
        //Happy Coding :)
        return (int) (cuts > 1 ?Math.Pow(cuts+1, 3) - Math.Pow(cuts-1, 3) : Math.Pow(cuts+1, 3));

        // Alternative
        // return n == 0 ? 1 : 6*n*n + 2;
    }

    public static void Main(){
        Console.WriteLine(CountSquares(5));
    }
}