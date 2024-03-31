// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
    public static string HoopCount(int n)
    {
        //Your code goes here
        return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
    }
    public static void Main()
    {
        Console.WriteLine(HoopCount(6));
        Console.WriteLine(HoopCount(22));
    }
}
