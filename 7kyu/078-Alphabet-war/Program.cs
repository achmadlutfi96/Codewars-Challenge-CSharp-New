using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string AlphabetWar(string fight)
    {
        IDictionary<char, int> left = new Dictionary<char, int>() { { 'w', 4 }, { 'p', 3 }, { 'b', 2 }, { 's', 1 } };
        IDictionary<char, int> right = new Dictionary<char, int>() { { 'm', 4 }, { 'q', 3 }, { 'd', 2 }, { 'z', 1 } };
        int result = fight.Select((x) => left.ContainsKey(x) ? left[x] : 0).Sum() - fight.Select((x) => right.ContainsKey(x) ? right[x] : 0).Sum();
        return result == 0 ? "Let's fight again!" : result > 0 ? "Left side wins!" : "Right side wins!";

        // Alternative
        // var score = fight.Sum(x => "sbpw".IndexOf(x) + 1 + -("zdqm".IndexOf(x) + 1));
        // return score == 0 ? "Let's fight again!" : score < 0 ? "Right side wins!" : "Left side wins!";
    }

    public static void Main()
    {
        Console.WriteLine(AlphabetWar("zzzzs"));
    }
}