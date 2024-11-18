public class Kata
{
    public static bool IsItLetter(char c)
    {
        return char.IsLetter(c);

        // Alternative
        // return ('A'<=c&&c<='Z')||('a'<=c&&c<='z');
    }  

    public static void Main()
    {
        Console.WriteLine(IsItLetter('a'));
    }
}