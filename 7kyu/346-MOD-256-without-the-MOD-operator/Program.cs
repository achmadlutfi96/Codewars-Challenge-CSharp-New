public class Kata
{
    public static int Mod256WithoutMod(int number)
    {
        return number - (number/256*256);
    }

    public static void Main()
    {
        Console.WriteLine(Mod256WithoutMod(254));
    }
}