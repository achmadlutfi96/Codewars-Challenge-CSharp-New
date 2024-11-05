public class Kata
{
    public static string[] Bald(string x)
    {
        string a = x.Replace("/", "-");
        string b = x.Replace("-", "");
        if (b.Length == 0)
        {
            b = "Clean!";
        }
        else if (b.Length == 1)
        {
            b = "Unicorn!";
        }
        else if (b.Length == 2)
        {
            b = "Homer!";
        }
        else if (b.Length >= 3 && b.Length <= 5)
        {
            b = "Careless!";
        }
        else
        {
            b = "Hobo!";
        }
        return new string[] { a, b };

        // Alternative
        // var n = x.Count(c => c == '/');
        //     return new[]
        //     {
        //     x.Replace('/', '-'),
        //     n == 0 ? "Clean!" : n == 1 ? "Unicorn!" : n == 2 ? "Homer!" : n < 6 ? "Careless!" : "Hobo!"
        // };
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Bald("--/--/---/-/---")));
    }
}