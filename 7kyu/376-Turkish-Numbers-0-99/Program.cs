public class Kata
{
    public static string GetTurkishNumber(int num)
    {
        // TODO
        string[] units = ["sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz"];
        string[] dozens = ["", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan"];
        return num < 10 ? units[num] : num%10 == 0 ? dozens[num/10] : $"{dozens[num/10]} {units[num%10]}";
    }

    public static void Main()
    {
        Console.WriteLine(GetTurkishNumber(3));
        Console.WriteLine(GetTurkishNumber(13));
    }
}
