using System;

public static class Kata
{
    public static string Sentencify(string[] words)
    {
        // throw new NotImplementedException();
        return char.ToUpper(words[0][0])+string.Join(" ", words).Substring(1)+".";

        // Alternative
        // return $"{char.ToUpper(words[0][0])}{string.Join(" ", words)[1..]}.";
    }

    public static void Main()
    {
        Console.WriteLine(Sentencify(new string[] {"i'm","afraid","I","can't","let","you","do","that"}));
    }
}