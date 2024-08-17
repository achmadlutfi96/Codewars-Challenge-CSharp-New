using System.Text.RegularExpressions;
using System.Linq;

public class Drinkin
{
    public static string hydrate(string drinkString)
    {
        // Insert party here
        int totalWater = Regex.Replace(drinkString, @"[A-Za-z]", ",").Replace(",", "").Split(" ").Where(x => !string.IsNullOrEmpty(x)).Sum(int.Parse);
        return string.Format("{0} {1} of water", totalWater, totalWater == 1 ? "glass" : "glasses");

        // Alternative
        //  var s = Regex.Matches(drinkString, "\\d").Sum(m => int.Parse(m.Value));
        // return $"{s} glass{(s > 1 ? "es" : "")} of water";
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(hydrate("1 beer"));
        Console.WriteLine(hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer"));
    }
}