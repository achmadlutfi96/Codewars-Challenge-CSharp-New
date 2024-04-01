// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Collections.Generic;
using System;

public static class Kata
{
    public static string Greet(string language)
    {
        // Happy Codding :)
        Dictionary<string, string> g = new Dictionary<string, string>(){
            {"english", "Welcome"},
            {"czech", "Vitejte"},
            {"danish", "Velkomst"},
            {"dutch", "Welkom"},
            {"estonian", "Tere tulemast"},
            {"finnish", "Tervetuloa"},
            {"flemish", "Welgekomen"},
            {"french", "Bienvenue"},
            {"german", "Willkommen"},
            {"irish", "Failte"},
            {"italian", "Benvenuto"},
            {"latvian", "Gaidits"},
            {"lithuanian", "Laukiamas"},
            {"polish", "Witamy"},
            {"spanish", "Bienvenido"},
            {"swedish", "Valkommen"},
            {"welsh", "Croeso"}
        };
        
        return g.ContainsKey(language) ? g[language] : g["english"];

        // Alternative
        // return language switch
    // {
    //     "czech" => "Vitejte",
    //     "danish" => "Velkomst",
    //     "dutch" => "Welkom",
    //     "estonian" => "Tere tulemast",
    //     "finnish" => "Tervetuloa",
    //     "flemish" => "Welgekomen",
    //     "french" => "Bienvenue",
    //     "german" => "Willkommen",
    //     "irish" => "Failte",
    //     "italian" => "Benvenuto",
    //     "latvian" => "Gaidits",
    //     "lithuanian" => "Laukiamas",
    //     "polish" => "Witamy",
    //     "spanish" => "Bienvenido",
    //     "swedish" => "Valkommen",
    //     "welsh" => "Croeso",
    //     _ => "Welcome"
    // };

    }
    public static void Main()
    {
        Console.WriteLine(Greet("english"));
    }
}