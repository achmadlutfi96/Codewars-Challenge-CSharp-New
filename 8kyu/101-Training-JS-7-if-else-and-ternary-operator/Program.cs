// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Kata
{
    public static int SaleHotDogs(int n)
    {
        return n<5 ? n*100 : n>=5 && n<10 ? n*95 : n*90;
        // Alternative
        // n * (n < 5 ? 100 : n < 10 ? 95 : 90);
    }
    public static void Main()
    {
        Console.WriteLine(SaleHotDogs(4));
    }
}
