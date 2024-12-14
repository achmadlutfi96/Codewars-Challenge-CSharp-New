public class Kata
{
    // double char in word
    public static bool StepThroughWith(string s) => s.Distinct().Any(x=>s.Contains($"{x}{x}"));
}