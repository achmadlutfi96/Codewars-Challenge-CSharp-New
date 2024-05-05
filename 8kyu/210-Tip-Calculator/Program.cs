using System;
public class Kata
{
    public static int CalculateTip(double amount, string rating)
    {
        return (int) Math.Ceiling(rating.ToLower() switch {
            "terrible" => 0,
            "poor" => amount * 0.05,
            "good" => amount * 0.1,
            "great" => amount * 0.15,
            "excellent" => amount * 0.2,
            _ => -1
        });
    }

    public static void Main()
    {
        Console.WriteLine(CalculateTip(20, "Excellent"));
        Console.WriteLine(CalculateTip(26.95, "good"));
    }
}