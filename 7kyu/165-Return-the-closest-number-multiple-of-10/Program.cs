using System;

public class Kata
{
    public static int ClosestMultiple10(int num)
    {
        return (int) Math.Round((double)num/10, MidpointRounding.AwayFromZero)*10;
    }

    public static void Main(){
        Console.WriteLine(ClosestMultiple10(25));
    }
}