using System;
public class Predicter
{
    public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
    {
        return (int)Math.Sqrt((age1 * age1) + (age2 * age2) + (age3 * age3) + (age4 * age4) + (age5 * age5) + (age6 * age6) + (age7 * age7) + (age8 * age8)) / 2;

        // Alternative
        // int[] ages = { age1, age2, age3, age4, age5, age6, age7, age8 };
        // return (int)(Sqrt(ages.Sum(x => x * x)) / 2);
    }

    public static void Main()
    {
        Console.WriteLine(PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
    }
}