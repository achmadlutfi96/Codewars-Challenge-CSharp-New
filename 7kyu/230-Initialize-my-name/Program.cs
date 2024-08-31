using System;
using System.Linq;

public class Kata
{
    public static string InitializeNames(string name)
    {
        if(name.Split(" ").Count() < 3){
            return name;
        }
        return string.Join(" ", name.Split(" ").First(), string.Join(" ",name.Split(" ").Skip(1).SkipLast(1).Select(x=>$"{x[0]}.")), name.Split(" ").Last());

        // Alternative
        // return name.Split().Skip(1).SkipLast(1).Aggregate(name, (s, n) => s.Replace(n, n[0] + "."));
    }

    public static void Main()
    {
        Console.WriteLine(InitializeNames("Alice Betty Catherine Davis"));
    }
}