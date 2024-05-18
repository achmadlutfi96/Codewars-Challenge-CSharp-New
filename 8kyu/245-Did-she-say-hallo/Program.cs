using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool Validate_hello(string greetings)
    {
        // your code
        string [] lang = new string[]{"hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc", "hallowen"};

        return Array.Exists(lang, (s)=> greetings.ToLower().Contains(s));

        // Alternative
        // return Regex.IsMatch(Greetings, "hello|ciao|salut|hallo|hola|ahoj|czesc", RegexOptions.IgnoreCase);
    }

    public static void Main(){
        Console.WriteLine(Validate_hello("hello"));
    }
}