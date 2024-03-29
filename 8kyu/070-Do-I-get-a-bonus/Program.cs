// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public static class Kata
{
    public static string bonus_time(int salary, bool bonus)
    {
        // your code
        return bonus ? $"${salary*10}" : $"${salary}";
    }
    public static void Main(){
        Console.WriteLine(bonus_time(10000, true));
    }
}
