using System;
class Kata
{
    public static long Layers(long n)
    {
        long l = 1;
        long m = 1;
        while((long)Math.Pow(m,2) < n){
            m+=2;
            l++;
        }
        return l;

        // Alternative
        // return (long)Math.Ceiling((Math.Sqrt(n) + 1) / 2);
    }

    public static void Main()
    {
        Console.WriteLine(Layers(1));
        Console.WriteLine(Layers(5));
        Console.WriteLine(Layers(25));
        Console.WriteLine(Layers(30));
        Console.WriteLine(Layers(50));
    }
}