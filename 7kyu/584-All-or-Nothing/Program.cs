using System.Linq;
public class Kata
{
    public static bool PossiblyPerfect(string[] key, string[] ans)
    {
        return key.Select((v, i) => v == ans[i] || v == "_" ? true : false).All(x => x == true) ||
                key.Select((v, i) => v != ans[i] || v == "_" ? false : true).All(x => x == false);
    }

    public static void Main()
    {
        Console.WriteLine(PossiblyPerfect("A_C_B".ToCharArray().Select(x => $"{x}").ToArray(), "ADCEB".ToCharArray().Select(x => $"{x}").ToArray()));
    }
}