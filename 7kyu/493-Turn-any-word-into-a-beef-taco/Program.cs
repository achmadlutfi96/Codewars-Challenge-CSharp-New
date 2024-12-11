using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
    public static string[] Tacofy(string word)
    {
        Dictionary<string, string> words = new() {
            {"aeiou", "beef"},
            {"t", "tomato"},
            {"l", "lettuce"},
            {"c", "cheese"},
            {"g", "guacamole"},
            {"s", "salsa"}
        };
        List<string> res = new() { "shell" };

        return res.Concat(word.ToLower().Select(x => words.Where(y => y.Key.Contains(x)).FirstOrDefault().Value).Where(x => x != null).Append("shell")).ToArray();

        // Alternative
        // return new List<string> {"shell"}.Concat(word.ToLower().Where(c => "aeioutlcgs".Contains(c))
        //   .Select(c => c switch
        //   {
        //       't' => "tomato",
        //       'c' => "cheese",
        //       'g' => "guacamole",
        //       'l' => "lettuce",
        //       's' => "salsa",
        //       _ => "beef"
        //   })).Append("shell").ToArray();
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Tacofy("ydjkpwqrzto")));
    }
}