using System;
using System.Linq;

public static class Kata
{
    public static int GolfScoreCalculator(string par, string score)
    {
        // throw new NotImplementedException();

        return(int) Enumerable.Range(0,par.Length).Select(i=>char.GetNumericValue(score[i])-char.GetNumericValue(par[i])).Sum();

        // Alternative
        // return s.Zip(p, (x, y) => x - y).Sum();
    }

    public static void Main()
    {
        Console.WriteLine(GolfScoreCalculator("453454444344544443", "354445334534445348"));
    }
}