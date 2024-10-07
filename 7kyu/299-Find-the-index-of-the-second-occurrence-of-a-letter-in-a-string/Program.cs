public class Kata
{
    public static int SecondSymbol(string str, char symbol)
    {
        if (!str.Contains(symbol))
        {
            return -1;
        }
        int[] res = str.Select((v, i) => v.Equals(symbol) ? i : -1).Where(x => x != -1).ToArray();
        return res.Length > 1 ? res[1] : -1;

        // Alternative 1
        // int occur = 0;
        // for (int i = 0; i < str.Length; i++) {
        //   if (str[i] == symbol) occur++;
        //   if (occur == 2) return i;
        // }
        // return -1;

        // Alternative 2
        // return str.IndexOf(symbol, str.IndexOf(symbol) + 1);

    }

    public static void Main()
    {
        Console.WriteLine(SecondSymbol("Hello world!!", 'l'));
        Console.WriteLine(SecondSymbol("", 'q'));
        Console.WriteLine(SecondSymbol(" ", 'q'));
    }
}