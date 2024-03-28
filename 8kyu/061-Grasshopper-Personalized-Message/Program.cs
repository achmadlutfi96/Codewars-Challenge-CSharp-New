// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
    public static string Greet(string name, string owner)
    {
        return name == owner ? "Hello boss":"Hello guest";
    }
    public static void Main()
    {
        Console.WriteLine(Greet("Daniel", "Daniel"));
    }
}
