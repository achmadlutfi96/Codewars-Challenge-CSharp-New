using System;
public class Kata
{
    public static int MaxMultiply(int divisor, int bound)
    {
        //Do some magic
        return (int) Math.Ceiling((double) (bound/divisor)) * divisor;

        // Alternative
        // return bound / divisor * divisor;
    }

    public static void Main(){
        Console.WriteLine(MaxMultiply(7, 100));
    }
}