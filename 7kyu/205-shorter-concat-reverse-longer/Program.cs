using System.Linq;
class ReverseLonger
{
    public static string ShorterReverseLonger(string a, string b)
    {
        // throw new System.NotImplementedException("Please provide some code!");
        if (a == null && b == null)
        {
            return string.Empty;
        }
        if (a == null)
        {
            return string.Concat(b.Reverse());
        }
        if (b == null)
        {
            return string.Concat(a.Reverse());
        }
        return a.Length >= b.Length ? $"{b}{string.Concat(a.Reverse())}{b}" : $"{a}{string.Concat(b.Reverse())}{a}";

        // Alternative
        // a ??= "";
        // b ??= "";
        // return b.Length > a.Length ? a + string.Concat(b.Reverse()) + a : b + string.Concat(a.Reverse()) + b;
    }

    public static void Main()
    {
        Console.WriteLine(ShorterReverseLonger("hello", "bau"));
        Console.WriteLine(ShorterReverseLonger("hello", null));
    }
}