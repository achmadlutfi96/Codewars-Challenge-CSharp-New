static class Kata
{
    public static bool vampire_test(long x, long y)
    {
        //Good Luck!
        string a = (x*y).ToString();
        string b = string.Concat(x.ToString(), y.ToString());
        return string.Concat(b.OrderBy(i=>i)) == string.Concat(a.OrderBy(i=>i));
        
        // Alternative 1
        // return (x * y).ToString().OrderBy(c => c).SequenceEqual((x.ToString() + y).OrderBy(c => c));
        
        // Alternative 2
        // return $"{x * y}".OrderBy(o => o).SequenceEqual($"{x}{y}".OrderBy(o => o));
    }

    public static void Main(String[] args)
    {
        Console.WriteLine(vampire_test(21, 6));
    }
}