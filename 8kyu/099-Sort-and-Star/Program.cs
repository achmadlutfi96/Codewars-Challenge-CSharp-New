// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections;
using System.Linq;

public class Kata
{
    public static string TwoSort(string[] s)
    {
        // StringComparer.Ordinal digunakan untuk string case sensitive yang huruf besar dan kecil dibedakan dan dibandingkan
        Array.Sort(s, StringComparer.Ordinal); 
        return String.Join("***", s.First().ToArray());

        // Alternative
        // return string.Join("***", s.OrderBy(a => a, StringComparer.Ordinal).First().ToArray());
    }
    public static void Main()
    {
        Console.WriteLine(TwoSort(new [] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps"}));
    }
}
