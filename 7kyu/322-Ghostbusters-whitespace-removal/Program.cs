public class Kata
{
    public static string GhostBusters(string building)
    {
        //Code goes here!
        return building.Contains(' ') ? building.Replace(" ","") : "You just wanted my autograph didn't you?";
    }

    public static void Main()
    {
        Console.WriteLine(GhostBusters("O  f fi ce"));
    }
}