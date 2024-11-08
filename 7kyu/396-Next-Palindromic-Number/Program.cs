public class Kata
{
    public static int NextPal(int val)
    {
        do
        {
            val++;
        }
        while (!(Convert.ToInt32(string.Concat(val.ToString().Reverse())) == val));

        return val;

        // Alternative 1
        // return Enumerable.Range(val + 1, val).First(x => $"{x}" == string.Concat($"{x}".Reverse()));
    }

    public static void Main()
    {
        Console.WriteLine(NextPal(11));
        Console.WriteLine(NextPal(188));
        Console.WriteLine(NextPal(191));
        Console.WriteLine(NextPal(2541));
    }
}