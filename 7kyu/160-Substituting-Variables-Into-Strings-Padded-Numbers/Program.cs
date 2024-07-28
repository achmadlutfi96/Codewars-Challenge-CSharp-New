public class PaddedNumbers
{
    public static string Solution(int value)
    {
        return $"Value is {value.ToString().PadLeft(5, '0')}";

        // Alternative
        // return $"Value is {value:D5}";
    }

    public static void Main()
    {
        Console.WriteLine(Solution(5));
    }
}