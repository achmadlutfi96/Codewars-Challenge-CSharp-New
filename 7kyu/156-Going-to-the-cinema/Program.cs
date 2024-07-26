using System;

public class MovieC
{

    public static int Movie(int card, int ticket, double perc)
    {
        double systemA = 0;
        double systemB = card;
        double prev = ticket;
        int times = 0;
        while (systemA <= Math.Ceiling(systemB))
        {
            systemA += ticket;
            prev *= perc;
            systemB += prev;
            times += 1;
        }
        return times;

    }

    public static void Main()
    {
        Console.WriteLine(Movie(500, 15, 0.9));
        Console.WriteLine(Movie(100, 10, 0.95));
    }
}