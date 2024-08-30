using System;
using System.Linq;

public class Kata
{
    public static string GetStrings(string city)
    {
        return string.Join(",", city.ToLower().Distinct().Where(x=>x!=' ').Select(x=>$"{x}:{string.Concat(Enumerable.Repeat('*',city.ToLower().Where(y=>y==x).Count()))}"));

        // Alternative
        // return string.Join(",", city.Where(char.IsLetter).GroupBy(char.ToLower).Select(g => $"{g.Key}:{new string('*', g.Count())}"));
    }

    public static void Main(){
        Console.WriteLine(GetStrings("Las Vegas"));
    }
}
