// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Multiplier
{
    public static int Multiply(int x)
    {
        // your code........
        return x%2 == 1 ? x*9 : x*8;
    }
    public static void Main()
    {
        Console.WriteLine(Multiply(1));
    }
}