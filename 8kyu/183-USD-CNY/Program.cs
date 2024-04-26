using System.Globalization;

public static class Kata
{
    public static string Usdcny(int usd)
    {
        return string.Format(new CultureInfo("en-US"), "{0:0.00} Chinese Yuan", usd * 6.75);

        // Alternative 1
        // return $"{(usd * 6.75f):0.00} Chinese Yuan";
        // Alternative 2
        // return $"{usd * 6.75:F} Chinese Yuan";
    }

    public static void Main(){
        Console.WriteLine(Usdcny(15));
        Console.WriteLine(Usdcny(465));
    }
}