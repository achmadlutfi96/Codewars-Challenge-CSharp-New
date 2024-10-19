public class TrimStringKata
{
    public static string TrimString(string phrase, int len)
    {
        if (phrase.Length > len)
        {
            if (len <= 3)
            {
                return phrase.Substring(0, len) + "...";
            }
            return phrase.Substring(0, len - 3) + "...";
        }
        return phrase;

        // Alternative
        // return phrase.Length > len ? phrase[..(len > 3 ? len - 3 : len)] + "..." : phrase;
    }

    public static void Main()
    {
        Console.WriteLine(TrimString("Creating kata is fun", 14));
        Console.WriteLine(TrimString("Hey", 3));
    }
}