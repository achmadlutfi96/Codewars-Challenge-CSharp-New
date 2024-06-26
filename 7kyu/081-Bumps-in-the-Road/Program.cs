using System.Linq;
class Kata
{
    public static string Bump(string input)
    {
        //Do Some Magic
        return input.Count(x=>x=='n') <= 15 ? "Woohoo!" : "Car Dead";
    }

    public static void Main(){
        Console.WriteLine(Bump("nnn_n__n_n___nnnnn___n__nnn__"));
    }
}