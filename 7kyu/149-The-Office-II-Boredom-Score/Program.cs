using System.Collections.Generic;

public class Kata
{

    public static string Boredom(Dictionary<string, string> staff)
    {
        Dictionary<string, int> scores = new() {
            {"accounts", 1},
            {"finance", 2},
            {"canteen", 10},
            {"regulation", 3},
            {"trading", 6},
            {"change", 6},
            {"IS", 8},
            {"retail", 5},
            {"cleaning", 4},
            {"pissing about", 25}
        };

        int score = 0;

        foreach (var item in staff)
        {
            score += scores[item.Value];
        }
        if (score <= 80)
        {
            return "kill me now";
        }
        else if (score < 100 && score > 80)
        {
            return "i can handle this";
        }
        else
        {
            return "party time!!";
        }

        // Alternative
    //     var score = staff.Sum(x => x.Value switch
    // {
    //     "accounts" => 1,
    //     "finance" => 2,
    //     "canteen" => 10,
    //     "regulation" => 3,
    //     "trading" => 6,
    //     "change" => 6,
    //     "IS" => 8,
    //     "retail" => 5,
    //     "cleaning" => 4,
    //     "pissing about" => 25,
    //     _ => 0
    // });

    //     return score >= 100 ? "party time!!" : score <= 80 ? "kill me now" : "i can handle this";
    }

    public static void Main()
    {
        Console.WriteLine(Boredom(new Dictionary<string, string>() { { "Jim", "pissing about" }, { "Tim", "regulation" }, { "Andy", "IS" }, { "Laura", "pissing about" }, { "Alex", "canteen" }, { "John", "canteen" } }));
    }

}