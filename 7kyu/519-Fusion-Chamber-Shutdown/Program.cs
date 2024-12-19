using System;
public class Kata
{
    public static (int, int, int) Burner(int c, int h, int o)
    {
        int water = Math.Min(h / 2, o);
        h -= 2 * water;
        o -= water;
        int co2 = Math.Min(c, o / 2);
        c -= co2;
        o -= 2 * co2;
        int methane = Math.Min(c, h / 4);

        return (water, co2, methane);

        // Alternative
        // var water = Min(h/2, o);
        // var co2 = Min(c, (o - water) / 2);
        // var methane = Min(c - co2, (h - (water * 2)) / 4);
        // return (water, co2, methane);
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Burner(45, 11, 100)));
    }
}