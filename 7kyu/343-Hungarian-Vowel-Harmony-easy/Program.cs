using System;
using System.Linq;
public static class Kata
{
    public static string Dative(string word)
    {
        char[] a = new char[]{'e', 'é', 'i', 'í', 'ö', 'ő', 'ü', 'ű'};
        char[] b = new char[]{'a', 'á', 'o', 'ó', 'u', 'ú'};
        return a.Contains(word.Where(x=> a.Contains(x) || b.Contains(x)).Last()) ? $"{word}nek" : $"{word}nak";

        // Alternative
        // return word + ("aáoóuú".Contains(word.Last(c => "eéiíöőüűaáoóuú".Contains(c))) ? "nak" : "nek");
    }

    public static void Main()
    {
        Console.WriteLine(Dative("virág"));
    }
}