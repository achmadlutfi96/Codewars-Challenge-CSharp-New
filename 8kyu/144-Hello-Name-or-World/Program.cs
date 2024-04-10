using System;
using System.Globalization;

public static class Kata
{
    public static string Hello(string name)
    {
        return name.Length != 0 ? $"Hello, {name.ToUpper()[0] + name.Substring(1, name.Length - 1).ToLower()}!" : "Hello, World!";
    }
    public static string Hello()
    {
        return "Hello, World!";
    }

    // Alternative
    // public static string Hello(string name = "")
    // {
    //     return string.IsNullOrEmpty(name)
    //         ? "Hello, World!"
    //         : $"Hello, {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower())}!";
    // }

    public static void Main()
    {
        Console.WriteLine(Hello("jEFF"));
        Console.WriteLine(Hello(""));
        Console.WriteLine(Hello());
    }
}