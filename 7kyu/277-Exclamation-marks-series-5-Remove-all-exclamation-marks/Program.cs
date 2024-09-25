public class Kata
{
    public static string Remove(string s)
    {
        //coding and coding....
        return string.Join(" ",s.Split(" ").Select(x=>x.TrimEnd('!')));

        // Alternative
        // return Regex.Replace(s, "\\b!*", "");
    }

    public static void Main()
    {
        Console.WriteLine(Remove("!!!Hi !!hi!!! !hi"));
    }
}