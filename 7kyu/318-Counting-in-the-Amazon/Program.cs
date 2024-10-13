public class Kata
{
    public static string CountArara(int n)
    {
        //your code here
        if (n == 1) return "anane";
        return string.Join(" ", Enumerable.Range(0, n/2).Select(x=>"adak")) + (n%2==1? " anane" : "");

        // Alternative
        // return string.Concat(Enumerable.Repeat("adak ", (n - 1) / 2)) + (n % 2 == 1 ? "anane" : "adak");
    }

    public static void Main()
    {
        Console.WriteLine(CountArara(1));
    }
}